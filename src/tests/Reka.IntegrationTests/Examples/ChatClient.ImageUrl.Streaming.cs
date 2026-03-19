/*
order: 90
title: Chat Client Image Url Streaming
slug: chat-client-image-url-streaming
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ImageUrl_Streaming()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var allText = new System.Text.StringBuilder();
        var updateCount = 0;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this image? Answer in one sentence."),
                    new UriContent(new Uri(TestImageUrl), "image/png"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            }))
        {
            updateCount++;
            if (update.Text is not null)
            {
                allText.Append(update.Text);
            }
        }

        Console.WriteLine($"Received {updateCount} chunks");
        Console.WriteLine($"Full text: {allText}");

        updateCount.Should().BeGreaterThan(1, "streaming should produce multiple chunks");
        allText.Length.Should().BeGreaterThan(0);
    }
}
