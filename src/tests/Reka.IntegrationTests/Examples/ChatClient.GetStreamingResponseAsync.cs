/*
order: 80
title: Chat Client Get Streaming Response Async
slug: chat-client-get-streaming-response-async
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetStreamingResponseAsync()
    {
        using var api = GetAuthenticatedClient();
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

        updateCount.Should().BeGreaterThan(1, "streaming should produce multiple chunks");
        allText.Length.Should().BeGreaterThan(0);
        responseId.Should().NotBeNullOrEmpty();
        modelId.Should().NotBeNullOrEmpty();
        finishReason.Should().Be(ChatFinishReason.Stop);
    }
}
