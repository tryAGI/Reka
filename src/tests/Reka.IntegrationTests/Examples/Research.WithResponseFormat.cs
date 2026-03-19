/*
order: 440
title: Research With Response Format
slug: research-with-response-format
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
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
