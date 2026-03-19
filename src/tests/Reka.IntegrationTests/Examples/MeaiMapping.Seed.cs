/*
order: 380
title: Meai Mapping Seed
slug: meai-mapping-seed
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_Seed()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                new ChatOptions
                {
                    ModelId = "reka-flash",
                    Seed = 42,
                });
        }
        catch { }

        var body = capture.LastRequestBody!.RootElement;
        body.GetProperty("seed").GetInt32().Should().Be(42);
    }
}
