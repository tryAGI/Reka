/*
order: 390
title: Meai Mapping System Message Converted To User
slug: meai-mapping-system-message-converted-to-user
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_SystemMessageConvertedToUser()
    {
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
        body.Should().NotBeNull();

        var messages = body!.RootElement.GetProperty("messages");
        messages.GetArrayLength().Should().Be(1, "system text should be prepended to the user message");
        messages[0].GetProperty("role").GetString().Should().Be("user");
        messages[0].GetProperty("content").GetString().Should().Contain("You are a helpful assistant.");
        messages[0].GetProperty("content").GetString().Should().Contain("Hello");
    }
}
