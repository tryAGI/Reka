/*
order: 300
title: Meai Mapping Data Content Audio
slug: meai-mapping-data-content-audio
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_DataContentAudio()
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
                        new DataContent(new byte[] { 0x52, 0x49, 0x46, 0x46 }, "audio/wav"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("audio_url");
        parts[1].GetProperty("audio_url").GetString().Should().StartWith("data:audio/wav;base64,");
    }
}
