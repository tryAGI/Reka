/*
order: 20
title: Chat Client Data Content Audio
slug: chat-client-data-content-audio
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_DataContent_Audio()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        // Download audio and send as inline DataContent (base64)
        using var httpClient = new HttpClient();
        var audioBytes = await httpClient.GetByteArrayAsync(TestAudioUrl);

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What language is spoken in this audio? Answer in one word."),
                    new DataContent(audioBytes, "audio/wav"),
                ]),
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
