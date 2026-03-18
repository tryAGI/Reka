namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Research_ChatCompletion()
    {
        using var api = GetAuthenticatedClient();

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

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Research_WithWebSearch()
    {
        using var api = GetAuthenticatedClient();

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

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();

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
    }

    [TestMethod]
    public async Task Research_WithParallelThinking()
    {
        using var api = GetAuthenticatedClient();

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

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();

        if (response.Choices[0].Message.ReasoningContent is not null)
        {
            Console.WriteLine($"Reasoning content: {response.Choices[0].Message.ReasoningContent}");
        }
    }

    [TestMethod]
    public async Task Research_WithResponseFormat()
    {
        using var api = GetAuthenticatedClient();

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

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();

        // Verify it's valid JSON
        var action = () => System.Text.Json.JsonDocument.Parse(response.Choices[0].Message.Content!);
        action.Should().NotThrow("response should be valid JSON");
    }
}
