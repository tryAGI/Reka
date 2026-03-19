/*
order: 150
title: Chat Client Response Format Json Schema
slug: chat-client-response-format-json-schema
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ResponseFormat_JsonSchema()
    {
        using var api = GetAuthenticatedClient();
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

        response.Text.Should().NotBeNullOrEmpty();

        // Verify it's valid JSON matching the schema
        var doc = JsonDocument.Parse(response.Text!);
        doc.RootElement.TryGetProperty("scientists", out var scientists).Should().BeTrue();
        scientists.GetArrayLength().Should().BeGreaterThanOrEqualTo(2);
    }
}
