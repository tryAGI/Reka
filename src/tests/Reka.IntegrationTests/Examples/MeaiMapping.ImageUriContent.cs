/*
order: 330
title: Meai Mapping Image Uri Content
slug: meai-mapping-image-uri-content
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_ImageUriContent()
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
                        new TextContent("Describe this"),
                        new UriContent(new Uri("https://example.com/image.png"), "image/png"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts.GetArrayLength().Should().Be(2);
        parts[0].GetProperty("type").GetString().Should().Be("text");
        parts[1].GetProperty("type").GetString().Should().Be("image_url");
        parts[1].GetProperty("image_url").GetString().Should().Be("https://example.com/image.png");
    }
}
