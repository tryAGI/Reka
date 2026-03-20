# Reka .NET SDK

[![NuGet](https://img.shields.io/nuget/v/tryAGI.Reka.svg)](https://www.nuget.org/packages/tryAGI.Reka/)

C# SDK for the [Reka](https://reka.ai/) AI platform, auto-generated from the Reka OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK).

## Installation

```bash
dotnet add package tryAGI.Reka
```

## Usage

### Create a client

```csharp
using Reka;

var client = new RekaClient("your-api-key");
```

### Chat completion

```csharp
var response = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is the capital of France?",
        },
    ],
    MaxTokens = 256,
});

Console.WriteLine(response.Choices[0].Message.Content);
```

### Streaming

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [new ChatMessage(ChatRole.User, "Count from 1 to 10")],
    new ChatOptions { ModelId = "reka-flash" }))
{
    Console.Write(update.Text);
}
```

### Microsoft.Extensions.AI (IChatClient)

The SDK implements `IChatClient` for seamless integration with the .NET AI ecosystem:

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello!")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine(response.Text);
```

### Tool calling

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var weatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72F and sunny.",
    "get_weather",
    "Gets the current weather for a location");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "What's the weather in Tokyo?")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        Tools = [weatherTool],
    });
```

### Multimodal (images, audio, video, PDF)

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image?"),
            new UriContent(new Uri("https://example.com/photo.png"), "image/png"),
        ]),
    ],
    new ChatOptions { ModelId = "reka-flash" });
```

### Structured JSON output

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var schema = System.Text.Json.JsonDocument.Parse("""
{
    "type": "object",
    "properties": {
        "name": { "type": "string" },
        "age": { "type": "integer" }
    },
    "required": ["name", "age"],
    "additionalProperties": false
}
""").RootElement;

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Return info about Alice who is 30.")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        ResponseFormat = new ChatResponseFormatJson(schema, "person", "A person object"),
    });
```

### Speech-to-text (ISpeechToTextClient)

```csharp
using Microsoft.Extensions.AI;

ISpeechToTextClient speechClient = new RekaClient("your-api-key");

await using var audioStream = File.OpenRead("recording.wav");
var response = await speechClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
```

### Speech transcription (raw API)

```csharp
var response = await client.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = "https://example.com/audio.wav",
    SamplingRate = 16000,
});

Console.WriteLine(response.Transcript);
```

### Translation

```csharp
var response = await client.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = "https://example.com/audio.wav",
    SamplingRate = 16000,
    TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
    IsTranslate = true,
});

Console.WriteLine(response.Translation);
```

### Research model

```csharp
var response = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What are the latest developments in quantum computing?",
        },
    ],
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig { Enabled = true, MaxUses = 5 },
        ParallelThinking = new ParallelThinkingConfig { Mode = ParallelThinkingConfigMode.Low },
    },
});
```

### List models

```csharp
var models = await client.Models.ListModelsAsync();

foreach (var model in models.Data)
{
    Console.WriteLine(model.Id);
}
```

<!-- EXAMPLES:START -->
### Chat Client Audio Url


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What language is spoken in this audio? Answer in one word."),
            new UriContent(new Uri(TestAudioUrl), "audio/wav"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Data Content Audio


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

// Download audio and send as inline DataContent (base64)
using var httpClient = new HttpClient();
var audioBytes = await httpClient.GetByteArrayAsync(TestAudioUrl);

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What language is spoken in this audio? Answer in one word."),
            new DataContent(audioBytes, "audio/wav"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Data Content Image


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

// Download image and send as inline DataContent (base64)
using var httpClient = new HttpClient();
var imageBytes = await httpClient.GetByteArrayAsync(TestImageUrl);

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new DataContent(imageBytes, "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Get Response Async


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [new(ChatRole.User, "Say hello in 5 words")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine(response.Text);
```

### Chat Client Get Service Metadata


```csharp
// These tests don't need a real API key — metadata is local-only
using var api = new RekaClient("dummy-key");
MeaiChatClient chatClient = api;

var metadata = chatClient.GetService<ChatClientMetadata>();
```

### Chat Client Get Service Self


```csharp
using var api = new RekaClient("dummy-key");
MeaiChatClient chatClient = api;

var self = chatClient.GetService<RekaClient>();
```

### Chat Client Get Service Unknown Returns Null


```csharp
using var api = new RekaClient("dummy-key");
MeaiChatClient chatClient = api;

var unknown = chatClient.GetService<string>();
```

### Chat Client Get Streaming Response Async


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var allText = new System.Text.StringBuilder();
var updateCount = 0;
string? responseId = null;
string? modelId = null;
ChatFinishReason? finishReason = null;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [new(ChatRole.User, "Count from 1 to 5")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    }))
{
    updateCount++;
    responseId ??= update.ResponseId;
    modelId ??= update.ModelId;
    finishReason = update.FinishReason ?? finishReason;

    if (update.Text is not null)
    {
        allText.Append(update.Text);
    }
}

Console.WriteLine($"Received {updateCount} chunks");
Console.WriteLine($"Full text: {allText}");
```

### Chat Client Image Url Streaming


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var allText = new System.Text.StringBuilder();
var updateCount = 0;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    }))
{
    updateCount++;
    if (update.Text is not null)
    {
        allText.Append(update.Text);
    }
}

Console.WriteLine($"Received {updateCount} chunks");
Console.WriteLine($"Full text: {allText}");
```

### Chat Client Image Url


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Invalid Model


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var action = () => chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello")],
    new ChatOptions
    {
        ModelId = "nonexistent-model-12345",
        MaxOutputTokens = 16,
    });
```

### Chat Client Max Tokens One


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Write a very long essay about the history of computing")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 1,
    });

Console.WriteLine($"Text: {response.Text}");
Console.WriteLine($"Finish reason: {response.FinishReason}");
```

### Chat Client Multiple Content Parts


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("Describe what you see."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
            new TextContent("Now summarize in exactly 3 words."),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Pdf Url


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What does this PDF document contain? Answer in one sentence."),
            new UriContent(new Uri(TestPdfUrl), "application/pdf"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Client Response Format Json Schema


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var schema = JsonSerializer.Deserialize<JsonElement>("""
    {
        "type": "object",
        "properties": {
            "scientists": {
                "type": "array",
                "items": {
                    "type": "object",
                    "properties": {
                        "name": { "type": "string" },
                        "field": { "type": "string" }
                    },
                    "required": ["name", "field"]
                }
            }
        },
        "required": ["scientists"]
    }
    """);

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "List 2 famous scientists and their field")],
    new ChatOptions
    {
        ModelId = "reka-flash-research",
        MaxOutputTokens = 256,
        ResponseFormat = ChatResponseFormat.ForJsonSchema(schema, "scientists_list", "A list of scientists"),
    });

Console.WriteLine($"Response: {response.Text}");

// Verify it's valid JSON matching the schema
var doc = JsonDocument.Parse(response.Text!);
```

### Chat Client Seed Reproducibility


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var options = new ChatOptions
{
    ModelId = "reka-flash",
    MaxOutputTokens = 32,
    Temperature = 0,
    Seed = 42,
};

var response1 = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
    options);

var response2 = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
    options);

Console.WriteLine($"Response 1: {response1.Text}");
Console.WriteLine($"Response 2: {response2.Text}");

// With same seed and temperature=0, outputs should be identical
```

### Chat Client Tool Calling Required Mode


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var getTimeTool = AIFunctionFactory.Create(
    (string timezone) => $"The current time in {timezone} is 2:30 PM.",
    "get_time",
    "Gets the current time in a timezone");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello!")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 256,
        Tools = [getTimeTool],
        ToolMode = ChatToolMode.RequireAny,
    });

Console.WriteLine($"Finish reason: {response.FinishReason}");

// With required tool mode, the model should always produce a tool call

var functionCalls = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .ToList();
```

### Chat Client Tool Calling Round Trip


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    "get_weather",
    "Gets the current weather for a location");

List<ChatMessage> messages =
[
    new(ChatRole.User, "What's the weather like in San Francisco? Use the tool to find out."),
];

var options = new ChatOptions
{
    ModelId = "reka-flash",
    MaxOutputTokens = 256,
    Tools = [getWeatherTool],
};

// First call: model should request tool
var response = await chatClient.GetResponseAsync(messages, options);

Console.WriteLine($"First response finish reason: {response.FinishReason}");

// Add assistant message with tool calls to conversation
messages.AddRange(response.Messages);

// Process each tool call and add results
foreach (var functionCall in response.Messages
             .SelectMany(m => m.Contents)
             .OfType<FunctionCallContent>())
{
    var result = await getWeatherTool.InvokeAsync(
        new AIFunctionArguments(functionCall.Arguments ?? new Dictionary<string, object?>()));

    messages.Add(new ChatMessage(ChatRole.Tool,
    [
        new FunctionResultContent(functionCall.CallId, result),
    ]));
}

// Second call: model should use tool result to answer
// Remove tools to prevent re-calling (Reka sends tool results as user messages)
var followUpOptions = new ChatOptions
{
    ModelId = options.ModelId,
    MaxOutputTokens = options.MaxOutputTokens,
};
var finalResponse = await chatClient.GetResponseAsync(messages, followUpOptions);

Console.WriteLine($"Final response: {finalResponse.Text}");
Console.WriteLine($"Final finish reason: {finalResponse.FinishReason}");
```

### Chat Client Tool Calling Streaming


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    "get_weather",
    "Gets the current weather for a location");

var updates = new List<Microsoft.Extensions.AI.ChatResponseUpdate>();
await foreach (var update in chatClient.GetStreamingResponseAsync(
    [new ChatMessage(ChatRole.User, "What's the weather like in San Francisco?")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 256,
        Tools = [getWeatherTool],
    }))
{
    updates.Add(update);
}

// Check that tool calls were emitted
var functionCalls = updates
    .SelectMany(u => u.Contents)
    .OfType<FunctionCallContent>()
    .ToList();

var toolCall = functionCalls[0];
Console.WriteLine($"Streaming tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");

// Check finish reason
var finishReason = updates.LastOrDefault(u => u.FinishReason is not null)?.FinishReason;
```

### Chat Client Tool Calling


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var getWeatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    "get_weather",
    "Gets the current weather for a location");

List<ChatMessage> messages =
[
    new(ChatRole.User, "What's the weather like in San Francisco?"),
];

var response = await chatClient.GetResponseAsync(
    messages,
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 256,
        Tools = [getWeatherTool],
    });

Console.WriteLine($"Finish reason: {response.FinishReason}");

// The model should request a tool call

var functionCalls = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .ToList();

var toolCall = functionCalls[0];
Console.WriteLine($"Tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
```

### Chat Client Video Url


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this video? Answer in one sentence."),
            new UriContent(new Uri(TestVideoUrl), "video/webm"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Completion Invalid Model


```csharp
using var api = new RekaClient(apiKey);

var action = () => api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "nonexistent-model-12345",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Hello",
        },
    ],
    MaxTokens = 16,
});
```

### Chat Completion Max Tokens One


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Write a very long essay about the history of computing",
        },
    ],
    MaxTokens = 1,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
Console.WriteLine($"Finish reason: {response.Choices[0].FinishReason}");

// With max_tokens=1, the model should hit the length limit
```

### Chat Completion Stop Sequence


```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Count from 1 to 10, separated by commas")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
        StopSequences = ["5"],
    });

Console.WriteLine($"Response: {response.Text}");

// The response should stop before or at "5"
```

### Chat Completion System Message As User


```csharp
// Reka doesn't support system role — verify it works when passed through IChatClient
// (system messages should be converted to user messages)
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.System, "You are a pirate. Always respond in pirate speak."),
        new ChatMessage(ChatRole.User, "Say hello"),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```

### Chat Completion Temperature


```csharp
using var api = new RekaClient(apiKey);

// Temperature 0 should produce deterministic output
var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is 2+2? Answer with just the number.",
        },
    ],
    MaxTokens = 16,
    Temperature = 0.0,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
```

### Chat Completion


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Say hello in 5 words",
        },
    ],
    MaxTokens = 64,
});

Console.WriteLine(response.Choices[0].Message.Content);
```

### Meai Mapping Assistant And Tool Roles


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User, "Hello"),
            new ChatMessage(ChatRole.Assistant, "Hi!"),
            new ChatMessage(ChatRole.Tool,
            [
                new FunctionResultContent("call_123", "result data"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var messages = capture.LastRequestBody!.RootElement.GetProperty("messages");
// Reka doesn't support tool_call_id on user messages — tool result is formatted as text
```

### Meai Mapping Audio Uri Content


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Transcribe"),
                new UriContent(new Uri("https://example.com/audio.wav"), "audio/wav"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Data Content Audio


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Transcribe"),
                new DataContent(new byte[] { 0x52, 0x49, 0x46, 0x46 }, "audio/wav"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Data Content Image


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("What is this?"),
                new DataContent(new byte[] { 0x89, 0x50, 0x4E, 0x47 }, "image/png"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Default Model


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        options: null);
}
catch { }

capture.LastRequestBody!.RootElement
```

### Meai Mapping Image Uri Content


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Describe this"),
                new UriContent(new Uri("https://example.com/image.png"), "image/png"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Multiple Text Contents Switch To Parts


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("First"),
                new TextContent("Second"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var content = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Options


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-core",
            MaxOutputTokens = 512,
            Temperature = 0.7f,
            TopP = 0.9f,
            TopK = 50,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.3f,
            StopSequences = ["END", "STOP"],
        });
}
catch { }

var root = capture.LastRequestBody!.RootElement;
```

### Meai Mapping Pdf Uri Content


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Summarize"),
                new UriContent(new Uri("https://example.com/doc.pdf"), "application/pdf"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Meai Mapping Response Format Json


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

var schema = JsonSerializer.Deserialize<JsonElement>("""
    {
        "type": "object",
        "properties": {
            "answer": { "type": "string" }
        },
        "required": ["answer"]
    }
    """);

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-flash",
            ResponseFormat = ChatResponseFormat.ForJsonSchema(schema, "test_schema", "A test schema"),
        });
}
catch { }

var body = capture.LastRequestBody!.RootElement;
var rf = body.GetProperty("response_format");
```

### Meai Mapping Seed


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-flash",
            Seed = 42,
        });
}
catch { }

var body = capture.LastRequestBody!.RootElement;
```

### Meai Mapping System Message Converted To User


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.System, "You are a helpful assistant."),
            new ChatMessage(ChatRole.User, "Hello"),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { /* expected — mock returns error */ }

var body = capture.LastRequestBody;

var messages = body!.RootElement.GetProperty("messages");
```

### Meai Mapping Video Uri Content


```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Describe video"),
                new UriContent(new Uri("https://example.com/video.mp4"), "video/mp4"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```

### Models


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Models.ListModelsAsync();

Console.WriteLine($"Available models: {response.Data.Count}");
foreach (var model in response.Data)
{
    Console.WriteLine($"  - {model.Id}");
}
```

### Research Chat Completion


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is the capital of France?",
        },
    ],
    MaxTokens = 256,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
```

### Research With Parallel Thinking


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Explain the theory of relativity in simple terms",
        },
    ],
    MaxTokens = 512,
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig
        {
            Enabled = true,
        },
        ParallelThinking = new ParallelThinkingConfig
        {
            Mode = ParallelThinkingConfigMode.Low,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

if (response.Choices[0].Message.ReasoningContent is not null)
{
    Console.WriteLine($"Reasoning content: {response.Choices[0].Message.ReasoningContent}");
}
```

### Research With Response Format


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "List 3 famous scientists and their main contribution",
        },
    ],
    MaxTokens = 512,
    ResponseFormat = new ResponseFormat
    {
        Type = ResponseFormatType.JsonSchema,
        JsonSchema = new JsonSchemaConfig
        {
            Name = "scientists",
            Description = "A list of scientists",
            Schema = System.Text.Json.JsonSerializer.Deserialize<object>("""
                {
                    "type": "object",
                    "properties": {
                        "scientists": {
                            "type": "array",
                            "items": {
                                "type": "object",
                                "properties": {
                                    "name": { "type": "string" },
                                    "contribution": { "type": "string" }
                                },
                                "required": ["name", "contribution"]
                            }
                        }
                    },
                    "required": ["scientists"]
                }
                """)!,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

// Verify it's valid JSON
var action = () => System.Text.Json.JsonDocument.Parse(response.Choices[0].Message.Content!);
```

### Research With Web Search


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is the current weather in Tokyo?",
        },
    ],
    MaxTokens = 512,
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig
        {
            Enabled = true,
            MaxUses = 3,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

// Research model may return reasoning steps and annotations
if (response.Choices[0].Message.ReasoningSteps is { Count: > 0 } steps)
{
    Console.WriteLine($"Reasoning steps: {steps.Count}");
    foreach (var step in steps)
    {
        Console.WriteLine($"  Step role={step.Role}: {step.ReasoningContent ?? step.Content}");
    }
}

if (response.Choices[0].Message.Annotations is { Count: > 0 } annotations)
{
    Console.WriteLine($"Annotations: {annotations.Count}");
    foreach (var annotation in annotations)
    {
        Console.WriteLine($"  Citation: {annotation.UrlCitation?.Title} - {annotation.UrlCitation?.Url}");
    }
}
```

### Speech To Text Client Get Service Metadata


```csharp
using var api = new RekaClient("dummy-key");
MeaiSpeechToTextClient speechClient = api;

var metadata = speechClient.GetService<SpeechToTextClientMetadata>();
```

### Speech To Text Client Get Service Self


```csharp
using var api = new RekaClient("dummy-key");
MeaiSpeechToTextClient speechClient = api;

var self = speechClient.GetService<RekaClient>();
```

### Speech To Text Client Get Streaming Text Async


```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    TestAudioUrl);

var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var updates = new List<SpeechToTextResponseUpdate>();
await foreach (var update in speechClient.GetStreamingTextAsync(ms))
{
    updates.Add(update);
    Console.WriteLine($"Update: {update.Text}");
}
```

### Speech To Text Client Get Text Async


```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Download a small WAV file and pass as stream
using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    TestAudioUrl);

// Buffer into MemoryStream since the API needs to convert to base64
var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var response = await speechClient.GetTextAsync(ms);

Console.WriteLine($"Text: {response.Text}");
```

### Speech To Text Client Translation


```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Use RawRepresentationFactory to configure translation via target_language
var options = new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new TranscribeOrTranslateRequest
    {
        AudioUrl = TestAudioUrl,
        SamplingRate = 16000,
        TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
        IsTranslate = true,
    },
};

using var emptyStream = new MemoryStream();
var response = await speechClient.GetTextAsync(emptyStream, options);

Console.WriteLine($"Transcript: {response.Text}");

// Verify the underlying response has the translation
var rawResponse = (TranscribeOrTranslateResponse)response.RawRepresentation!;
Console.WriteLine($"Translation: {rawResponse.Translation}");
```

### Speech To Text Client With Raw Representation Factory


```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Use RawRepresentationFactory to pass a pre-configured request with a URL
var options = new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new TranscribeOrTranslateRequest
    {
        AudioUrl = TestAudioUrl,
        SamplingRate = 16000,
    },
};

// Pass an empty stream since URL is provided via factory
using var emptyStream = new MemoryStream();
var response = await speechClient.GetTextAsync(emptyStream, options);

Console.WriteLine($"Text: {response.Text}");
```

### Transcribe Audio


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = TestAudioUrl,
    SamplingRate = 16000,
});

Console.WriteLine($"Transcript: {response.Transcript}");
```

### Translate Audio


```csharp
using var api = new RekaClient(apiKey);

var response = await api.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = TestAudioUrl,
    SamplingRate = 16000,
    TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
    IsTranslate = true,
});

Console.WriteLine($"Transcript: {response.Transcript}");
Console.WriteLine($"Translation: {response.Translation}");

// Note: transcript_translation_with_timestamp may not be returned for translations
```
<!-- EXAMPLES:END -->

## License

[MIT](LICENSE)
