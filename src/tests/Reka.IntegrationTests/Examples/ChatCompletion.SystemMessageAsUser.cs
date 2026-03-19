/*
order: 250
title: Chat Completion System Message As User
slug: chat-completion-system-message-as-user
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_SystemMessageAsUser()
    {
        // Reka doesn't support system role — verify it works when passed through IChatClient
        // (system messages should be converted to user messages)
        using var api = GetAuthenticatedClient();
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

        response.Text.Should().NotBeNullOrEmpty();
    }
}
