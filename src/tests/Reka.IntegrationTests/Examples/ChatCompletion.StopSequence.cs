/*
order: 240
title: Chat Completion Stop Sequence
slug: chat-completion-stop-sequence
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_StopSequence()
    {
        using var api = GetAuthenticatedClient();
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
        response.Text.Should().NotBeNullOrEmpty();
        response.Text.Should().NotContain("6", "output should stop before reaching 6");
    }
}
