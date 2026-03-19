/*
order: 340
title: Meai Mapping Multiple Text Contents Switch To Parts
slug: meai-mapping-multiple-text-contents-switch-to-parts
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_MultipleTextContentsSwitchToParts()
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
                        new TextContent("First"),
                        new TextContent("Second"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var content = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        content.ValueKind.Should().Be(JsonValueKind.Array);
        content.GetArrayLength().Should().Be(2);
        content[0].GetProperty("text").GetString().Should().Be("First");
        content[1].GetProperty("text").GetString().Should().Be("Second");
    }
}
