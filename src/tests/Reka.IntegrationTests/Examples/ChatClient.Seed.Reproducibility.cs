/*
order: 160
title: Chat Client Seed Reproducibility
slug: chat-client-seed-reproducibility
*/

using System.Text.Json;
using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_Seed_Reproducibility()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var options = new ChatOptions
        {
            ModelId = "reka-flash",
            MaxOutputTokens = 32,
            Temperature = 0,
            Seed = 42,
        };

        var response1 = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
            options);

        var response2 = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
            options);

        Console.WriteLine($"Response 1: {response1.Text}");
        Console.WriteLine($"Response 2: {response2.Text}");

        response1.Text.Should().NotBeNullOrEmpty();
        response2.Text.Should().NotBeNullOrEmpty();
        // With same seed and temperature=0, outputs should be identical
        response1.Text.Should().Be(response2.Text, "same seed and temperature=0 should produce identical outputs");
    }
}
