/*
order: 120
title: Chat Client Max Tokens One
slug: chat-client-max-tokens-one
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_MaxTokensOne()
    {
        using var api = GetAuthenticatedClient();
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

        response.FinishReason.Should().Be(ChatFinishReason.Length);
    }
}
