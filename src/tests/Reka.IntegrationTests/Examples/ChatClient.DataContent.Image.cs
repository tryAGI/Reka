/*
order: 30
title: Chat Client Data Content Image
slug: chat-client-data-content-image
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_DataContent_Image()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        // Download image and send as inline DataContent (base64)
        using var httpClient = new HttpClient();
        var imageBytes = await httpClient.GetByteArrayAsync(TestImageUrl);

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this image? Answer in one sentence."),
                    new DataContent(imageBytes, "image/png"),
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
