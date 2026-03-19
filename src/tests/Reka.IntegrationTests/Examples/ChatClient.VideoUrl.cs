/*
order: 210
title: Chat Client Video Url
slug: chat-client-video-url
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_VideoUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this video? Answer in one sentence."),
                    new UriContent(new Uri(TestVideoUrl), "video/webm"),
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
