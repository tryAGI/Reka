using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

using ChatRole = Microsoft.Extensions.AI.ChatRole;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

// ReSharper disable once CheckNamespace
namespace Reka;

public partial class RekaClient : Microsoft.Extensions.AI.IChatClient
{
    private Microsoft.Extensions.AI.ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? Microsoft.Extensions.AI.IChatClient.GetService(Type? serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(Microsoft.Extensions.AI.ChatClientMetadata) ? (_metadata ??= new(nameof(RekaClient), this.BaseUri)) :
            serviceType?.IsInstanceOfType(this) is true ? this :
            null;
    }

    [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026",
        Justification = "Tool call parameters require dynamic serialization.")]
    async Task<Microsoft.Extensions.AI.ChatResponse> Microsoft.Extensions.AI.IChatClient.GetResponseAsync(
        IEnumerable<ChatMessage> messages, Microsoft.Extensions.AI.ChatOptions? options, CancellationToken cancellationToken)
    {
        var request = CreateMeaiRequest(messages, options);

        var response = await Chat.CreateChatCompletionAsync(request, cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        ChatMessage responseMessage = new()
        {
            Role = ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (response.Choices is { Count: > 0 })
        {
            var choice = response.Choices[0];

            if (choice.Message.Content is not null)
            {
                responseMessage.Contents.Add(new Microsoft.Extensions.AI.TextContent(choice.Message.Content)
                {
                    RawRepresentation = choice.Message,
                });
            }

            if (choice.Message.ToolCalls is { Count: > 0 })
            {
                foreach (var toolCall in choice.Message.ToolCalls)
                {
                    Dictionary<string, object?>? args = null;
                    if (!string.IsNullOrEmpty(toolCall.Function.Arguments))
                    {
                        args = JsonSerializer.Deserialize<Dictionary<string, object?>>(toolCall.Function.Arguments);
                    }

                    responseMessage.Contents.Add(new Microsoft.Extensions.AI.FunctionCallContent(
                        toolCall.Id,
                        toolCall.Function.Name,
                        args)
                    {
                        RawRepresentation = toolCall,
                    });
                }
            }
        }

        Microsoft.Extensions.AI.ChatResponse completion = new(responseMessage)
        {
            RawRepresentation = response,
            ResponseId = response.Id,
            ModelId = response.Model,
            FinishReason = response.Choices is { Count: > 0 }
                ? response.Choices[0].FinishReason switch
                {
                    ChoiceFinishReason.Stop => Microsoft.Extensions.AI.ChatFinishReason.Stop,
                    ChoiceFinishReason.Length => Microsoft.Extensions.AI.ChatFinishReason.Length,
                    ChoiceFinishReason.ToolCalls => Microsoft.Extensions.AI.ChatFinishReason.ToolCalls,
                    ChoiceFinishReason.Context => Microsoft.Extensions.AI.ChatFinishReason.Length,
                    _ => null,
                }
                : null,
        };

        if (response.Usage is { } u)
        {
            completion.Usage = new()
            {
                InputTokenCount = u.PromptTokens,
                OutputTokenCount = u.CompletionTokens,
                TotalTokenCount = u.TotalTokens,
            };
        }

        return completion;
    }

    [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026",
        Justification = "Tool call parameters require dynamic serialization.")]
    async IAsyncEnumerable<Microsoft.Extensions.AI.ChatResponseUpdate> Microsoft.Extensions.AI.IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, Microsoft.Extensions.AI.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var request = CreateMeaiRequest(messages, options);
        request.Stream = true;

        var jsonBody = request.ToJson(JsonSerializerContext);
        using var httpRequest = new HttpRequestMessage(HttpMethod.Post, "/v1/chat/completions")
        {
            Content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json"),
        };

        foreach (var auth in Authorizations)
        {
            if (auth.Type == "ApiKey" && auth.Location == "Header")
            {
                httpRequest.Headers.Add(auth.Name, auth.Value);
            }
        }

        using var httpResponse = await HttpClient.SendAsync(
            httpRequest,
            HttpCompletionOption.ResponseHeadersRead,
            cancellationToken).ConfigureAwait(false);

        httpResponse.EnsureSuccessStatusCode();

        using var stream = await httpResponse.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
        using var reader = new StreamReader(stream);

        // Accumulate streaming tool call deltas by index
        var toolCallAccumulator = new Dictionary<int, (string? Id, string? Name, System.Text.StringBuilder Arguments)>();

        string? line;
        while ((line = await reader.ReadLineAsync(cancellationToken).ConfigureAwait(false)) is not null)
        {
            if (!line.StartsWith("data: ", StringComparison.Ordinal))
            {
                continue;
            }

            var data = line["data: ".Length..];
            if (data == "[DONE]")
            {
                break;
            }

            StreamChunk? chunk;
            try
            {
                chunk = JsonSerializer.Deserialize(data, StreamingJsonContext.Default.StreamChunk);
            }
            catch (JsonException)
            {
                continue;
            }

            if (chunk is null)
            {
                continue;
            }

            var update = new Microsoft.Extensions.AI.ChatResponseUpdate
            {
                ResponseId = chunk.Id,
                ModelId = chunk.Model,
            };

            if (chunk.Choices is { Count: > 0 })
            {
                var choice = chunk.Choices[0];

                if (choice.Delta?.Role is not null)
                {
                    update.Role = ChatRole.Assistant;
                }

                if (choice.Delta?.Content is not null)
                {
                    update.Contents.Add(new Microsoft.Extensions.AI.TextContent(choice.Delta.Content));
                }

                // Accumulate tool call deltas
                if (choice.Delta?.ToolCalls is { Count: > 0 })
                {
                    foreach (var tc in choice.Delta.ToolCalls)
                    {
                        if (!toolCallAccumulator.TryGetValue(tc.Index, out var acc))
                        {
                            acc = (tc.Id, tc.Function?.Name, new System.Text.StringBuilder());
                            toolCallAccumulator[tc.Index] = acc;
                        }
                        else
                        {
                            if (tc.Id is not null) acc = acc with { Id = tc.Id };
                            if (tc.Function?.Name is not null) acc = acc with { Name = tc.Function.Name };
                            toolCallAccumulator[tc.Index] = acc;
                        }

                        if (tc.Function?.Arguments is not null)
                        {
                            toolCallAccumulator[tc.Index].Arguments.Append(tc.Function.Arguments);
                        }
                    }
                }

                if (choice.FinishReason is not null)
                {
                    update.FinishReason = choice.FinishReason switch
                    {
                        "stop" => Microsoft.Extensions.AI.ChatFinishReason.Stop,
                        "length" or "context" => Microsoft.Extensions.AI.ChatFinishReason.Length,
                        "tool_calls" => Microsoft.Extensions.AI.ChatFinishReason.ToolCalls,
                        _ => null,
                    };

                    // Emit accumulated tool calls when streaming completes
                    if (choice.FinishReason == "tool_calls" && toolCallAccumulator.Count > 0)
                    {
                        foreach (var (_, (id, name, argsBuilder)) in toolCallAccumulator)
                        {
                            var argsStr = argsBuilder.ToString();
                            Dictionary<string, object?>? args = null;
                            if (!string.IsNullOrEmpty(argsStr))
                            {
                                try { args = JsonSerializer.Deserialize<Dictionary<string, object?>>(argsStr); }
                                catch (JsonException) { /* best effort */ }
                            }

                            update.Contents.Add(new Microsoft.Extensions.AI.FunctionCallContent(
                                id ?? string.Empty, name ?? string.Empty, args));
                        }

                        toolCallAccumulator.Clear();
                    }
                }
            }

            if (chunk.Usage is { } usage)
            {
                update.Contents.Add(new Microsoft.Extensions.AI.UsageContent(new()
                {
                    InputTokenCount = usage.InputTokens ?? usage.PromptTokens,
                    OutputTokenCount = usage.OutputTokens ?? usage.CompletionTokens,
                    TotalTokenCount = usage.TotalTokens
                        ?? (usage.InputTokens ?? usage.PromptTokens ?? 0) + (usage.OutputTokens ?? usage.CompletionTokens ?? 0),
                }));
            }

            yield return update;
        }
    }

    [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2026",
        Justification = "Tool call parameters require dynamic serialization.")]
    private static CreateChatCompletionRequest CreateMeaiRequest(
        IEnumerable<ChatMessage> chatMessages, Microsoft.Extensions.AI.ChatOptions? options)
    {
        List<ChatMessageInput> messages = [];
        string? pendingSystemText = null;

        foreach (var chatMessage in chatMessages)
        {
            if (chatMessage.Role == ChatRole.System)
            {
                // Reka doesn't have a system role — accumulate system text
                // to prepend to the next user message.
                var systemText = string.Concat(chatMessage.Contents
                    .OfType<Microsoft.Extensions.AI.TextContent>()
                    .Select(c => c.Text));
                if (!string.IsNullOrEmpty(systemText))
                {
                    pendingSystemText = pendingSystemText is null
                        ? systemText
                        : pendingSystemText + "\n" + systemText;
                }

                continue;
            }

            // Reka requires strict user/assistant alternation.
            // Tool result messages are sent as "user" role with formatted content
            // (Reka doesn't support "tool" role and crashes on tool_call_id in user messages).
            bool isToolResult = chatMessage.Role == ChatRole.Tool;
            ChatMessageInputRole role = chatMessage.Role == ChatRole.Assistant
                ? ChatMessageInputRole.Assistant
                : ChatMessageInputRole.User;

            List<ContentPart>? parts = null;
            string? textContent = null;
            List<ToolCall>? toolCalls = null;

            foreach (var content in chatMessage.Contents)
            {
                switch (content)
                {
                    case Microsoft.Extensions.AI.TextContent tc:
                        if (parts is not null)
                        {
                            parts.Add(new ContentPart
                            {
                                Type = ContentPartType.Text,
                                Text = tc.Text,
                            });
                        }
                        else if (textContent is not null)
                        {
                            // Multiple text contents — switch to parts mode
                            parts =
                            [
                                new ContentPart
                                {
                                    Type = ContentPartType.Text,
                                    Text = textContent,
                                },
                                new ContentPart
                                {
                                    Type = ContentPartType.Text,
                                    Text = tc.Text,
                                },
                            ];
                            textContent = null;
                        }
                        else
                        {
                            textContent = tc.Text;
                        }

                        break;

                    case Microsoft.Extensions.AI.UriContent uc when uc.HasTopLevelMediaType("image"):
                        parts ??= [];
                        if (textContent is not null)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.Text, Text = textContent });
                            textContent = null;
                        }

                        parts.Add(new ContentPart
                        {
                            Type = ContentPartType.ImageUrl,
                            ImageUrl = uc.Uri.ToString(),
                        });
                        break;

                    case Microsoft.Extensions.AI.UriContent uc when uc.MediaType?.StartsWith("audio", StringComparison.OrdinalIgnoreCase) is true:
                        parts ??= [];
                        if (textContent is not null)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.Text, Text = textContent });
                            textContent = null;
                        }

                        parts.Add(new ContentPart
                        {
                            Type = ContentPartType.AudioUrl,
                            AudioUrl = uc.Uri.ToString(),
                        });
                        break;

                    case Microsoft.Extensions.AI.UriContent uc when uc.MediaType?.StartsWith("video", StringComparison.OrdinalIgnoreCase) is true:
                        parts ??= [];
                        if (textContent is not null)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.Text, Text = textContent });
                            textContent = null;
                        }

                        parts.Add(new ContentPart
                        {
                            Type = ContentPartType.VideoUrl,
                            VideoUrl = uc.Uri.ToString(),
                        });
                        break;

                    case Microsoft.Extensions.AI.UriContent uc when uc.MediaType?.Equals("application/pdf", StringComparison.OrdinalIgnoreCase) is true:
                        parts ??= [];
                        if (textContent is not null)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.Text, Text = textContent });
                            textContent = null;
                        }

                        parts.Add(new ContentPart
                        {
                            Type = ContentPartType.PdfUrl,
                            PdfUrl = uc.Uri.ToString(),
                        });
                        break;

                    case Microsoft.Extensions.AI.DataContent dc:
                        parts ??= [];
                        if (textContent is not null)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.Text, Text = textContent });
                            textContent = null;
                        }

                        var dataUri = dc.Uri;
                        if (dc.HasTopLevelMediaType("image"))
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.ImageUrl, ImageUrl = dataUri });
                        }
                        else if (dc.HasTopLevelMediaType("audio"))
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.AudioUrl, AudioUrl = dataUri });
                        }
                        else if (dc.HasTopLevelMediaType("video"))
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.VideoUrl, VideoUrl = dataUri });
                        }
                        else if (dc.MediaType?.Equals("application/pdf", StringComparison.OrdinalIgnoreCase) is true)
                        {
                            parts.Add(new ContentPart { Type = ContentPartType.PdfUrl, PdfUrl = dataUri });
                        }

                        break;

                    case Microsoft.Extensions.AI.FunctionCallContent fcc:
                        toolCalls ??= [];
                        toolCalls.Add(new ToolCall
                        {
                            Id = fcc.CallId,
                            Type = ToolCallType.Function,
                            Function = new FunctionCall
                            {
                                Name = fcc.Name,
                                Arguments = fcc.Arguments is not null
                                    ? JsonSerializer.Serialize(fcc.Arguments)
                                    : "{}",
                            },
                        });
                        break;

                    case Microsoft.Extensions.AI.FunctionResultContent frc:
                        // Reka doesn't support tool_call_id on user messages (causes 500).
                        // Format the result as text so the model can use it.
                        var resultText = frc.Result?.ToString() ?? string.Empty;
                        textContent = isToolResult
                            ? $"[Tool result for {frc.CallId}]: {resultText}"
                            : resultText;
                        break;
                }
            }

            // Prepend any accumulated system text to this user message
            if (pendingSystemText is not null && role == ChatMessageInputRole.User)
            {
                if (parts is not null)
                {
                    parts.Insert(0, new ContentPart
                    {
                        Type = ContentPartType.Text,
                        Text = pendingSystemText,
                    });
                }
                else if (textContent is not null)
                {
                    textContent = pendingSystemText + "\n" + textContent;
                }
                else
                {
                    textContent = pendingSystemText;
                }

                pendingSystemText = null;
            }

            var msg = new ChatMessageInput
            {
                Role = role,
                ToolCalls = toolCalls,
            };

            if (parts is not null)
            {
                msg.Content = new OneOf<string, IList<ContentPart>>(parts);
            }
            else if (textContent is not null)
            {
                msg.Content = new OneOf<string, IList<ContentPart>>(textContent);
            }

            messages.Add(msg);
        }

        // If system text remains with no user message after it, add as standalone user message
        if (pendingSystemText is not null)
        {
            messages.Add(new ChatMessageInput
            {
                Role = ChatMessageInputRole.User,
                Content = pendingSystemText,
            });
        }

        var request = new CreateChatCompletionRequest
        {
            Model = options?.ModelId ?? "reka-flash",
            Messages = messages,
            MaxTokens = options?.MaxOutputTokens,
            Temperature = options?.Temperature,
            TopP = options?.TopP,
            TopK = options?.TopK,
            Stop = options?.StopSequences?.ToList(),
            FrequencyPenalty = options?.FrequencyPenalty,
            PresencePenalty = options?.PresencePenalty,
            Seed = options?.Seed is { } seed ? (int)seed : null,
        };

        if (options?.ResponseFormat is Microsoft.Extensions.AI.ChatResponseFormatJson jsonFormat)
        {
            request.ResponseFormat = new ResponseFormat
            {
                Type = ResponseFormatType.JsonSchema,
                JsonSchema = new JsonSchemaConfig
                {
                    Name = jsonFormat.SchemaName ?? "response",
                    Description = jsonFormat.SchemaDescription,
                    Schema = jsonFormat.Schema is { } schema
                        ? JsonSerializer.Deserialize<object>(schema.GetRawText()) ?? new { type = "object" }
                        : new { type = "object" },
                },
            };
        }

        if (options?.Tools is { Count: > 0 } aiTools)
        {
            var tools = new List<Reka.Tool>();
            foreach (var tool in aiTools)
            {
                if (tool is Microsoft.Extensions.AI.AIFunction f)
                {
                    tools.Add(new Reka.Tool
                    {
                        Name = f.Name,
                        Description = f.Description,
                        Parameters = f.JsonSchema,
                    });
                }
            }

            if (tools.Count > 0)
            {
                request.Tools = tools;

                request.ToolChoice = options?.ToolMode switch
                {
                    Microsoft.Extensions.AI.RequiredChatToolMode => CreateChatCompletionRequestToolChoice.Tool,
                    _ => CreateChatCompletionRequestToolChoice.Auto,
                };
            }
        }

        return request;
    }
}

[JsonSerializable(typeof(StreamChunk))]
[JsonSerializable(typeof(StreamToolCall))]
[JsonSerializable(typeof(StreamFunctionCall))]
[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
internal sealed partial class StreamingJsonContext : JsonSerializerContext;

internal sealed class StreamChunk
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("choices")]
    public IList<StreamChoice>? Choices { get; set; }

    [JsonPropertyName("usage")]
    public StreamUsage? Usage { get; set; }
}

internal sealed class StreamChoice
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("delta")]
    public StreamDelta? Delta { get; set; }

    [JsonPropertyName("finish_reason")]
    public string? FinishReason { get; set; }
}

internal sealed class StreamDelta
{
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("tool_calls")]
    public IList<StreamToolCall>? ToolCalls { get; set; }
}

internal sealed class StreamToolCall
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("function")]
    public StreamFunctionCall? Function { get; set; }
}

internal sealed class StreamFunctionCall
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("arguments")]
    public string? Arguments { get; set; }
}

internal sealed class StreamUsage
{
    [JsonPropertyName("input_tokens")]
    public int? InputTokens { get; set; }

    [JsonPropertyName("output_tokens")]
    public int? OutputTokens { get; set; }

    [JsonPropertyName("prompt_tokens")]
    public int? PromptTokens { get; set; }

    [JsonPropertyName("completion_tokens")]
    public int? CompletionTokens { get; set; }

    [JsonPropertyName("total_tokens")]
    public int? TotalTokens { get; set; }
}
