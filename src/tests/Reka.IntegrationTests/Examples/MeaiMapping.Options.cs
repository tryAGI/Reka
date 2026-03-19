/*
order: 350
title: Meai Mapping Options
slug: meai-mapping-options
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MeaiMapping_Options()
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
                    ModelId = "reka-core",
                    MaxOutputTokens = 512,
                    Temperature = 0.7f,
                    TopP = 0.9f,
                    TopK = 50,
                    FrequencyPenalty = 0.5f,
                    PresencePenalty = 0.3f,
                    StopSequences = ["END", "STOP"],
                });
        }
        catch { }

        var root = capture.LastRequestBody!.RootElement;
        root.GetProperty("model").GetString().Should().Be("reka-core");
        root.GetProperty("max_tokens").GetInt32().Should().Be(512);
        root.GetProperty("temperature").GetDouble().Should().BeApproximately(0.7, 0.01);
        root.GetProperty("top_p").GetDouble().Should().BeApproximately(0.9, 0.01);
        root.GetProperty("top_k").GetInt32().Should().Be(50);
        root.GetProperty("frequency_penalty").GetDouble().Should().BeApproximately(0.5, 0.01);
        root.GetProperty("presence_penalty").GetDouble().Should().BeApproximately(0.3, 0.01);
        root.GetProperty("stop").GetArrayLength().Should().Be(2);
    }
}
