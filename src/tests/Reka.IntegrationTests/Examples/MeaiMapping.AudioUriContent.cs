/*
order: 290
title: Meai Mapping Audio Uri Content
slug: meai-mapping-audio-uri-content
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_AudioUriContent()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Transcribe"),
                        new UriContent(new Uri("https://example.com/audio.wav"), "audio/wav"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("audio_url");
        parts[1].GetProperty("audio_url").GetString().Should().Be("https://example.com/audio.wav");
    }
}
