/*
order: 370
title: Meai Mapping Response Format Json
slug: meai-mapping-response-format-json
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_ResponseFormatJson()
    {
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
        rf.GetProperty("type").GetString().Should().Be("json_schema");
        rf.GetProperty("json_schema").GetProperty("name").GetString().Should().Be("test_schema");
        rf.GetProperty("json_schema").GetProperty("description").GetString().Should().Be("A test schema");
        rf.GetProperty("json_schema").GetProperty("schema").GetProperty("type").GetString().Should().Be("object");
    }
}
