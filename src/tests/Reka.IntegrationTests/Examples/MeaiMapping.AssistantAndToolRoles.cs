/*
order: 280
title: Meai Mapping Assistant And Tool Roles
slug: meai-mapping-assistant-and-tool-roles
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_AssistantAndToolRoles()
    {
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
        messages.GetArrayLength().Should().Be(3);
        messages[0].GetProperty("role").GetString().Should().Be("user");
        messages[1].GetProperty("role").GetString().Should().Be("assistant");
        messages[2].GetProperty("role").GetString().Should().Be("user", "Reka maps tool role to user");
        // Reka doesn't support tool_call_id on user messages — tool result is formatted as text
        messages[2].GetProperty("content").GetString().Should().Contain("[Tool result for call_123]");
    }
}
