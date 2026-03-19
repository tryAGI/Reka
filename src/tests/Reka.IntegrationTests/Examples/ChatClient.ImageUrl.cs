/*
order: 100
title: Chat Client Image Url
slug: chat-client-image-url
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ImageUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
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
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }
}
