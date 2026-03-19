/*
order: 360
title: Meai Mapping Pdf Uri Content
slug: meai-mapping-pdf-uri-content
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_PdfUriContent()
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
                        new TextContent("Summarize"),
                        new UriContent(new Uri("https://example.com/doc.pdf"), "application/pdf"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("pdf_url");
    }
}
