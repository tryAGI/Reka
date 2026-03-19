/*
order: 320
title: Meai Mapping Default Model
slug: meai-mapping-default-model
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_DefaultModel()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                options: null);
        }
        catch { }

        capture.LastRequestBody!.RootElement
            .GetProperty("model").GetString().Should().Be("reka-flash");
    }
}
