/*
order: 40
title: Chat Client Get Response Async
slug: chat-client-get-response-async
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_GetResponseAsync()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [new(ChatRole.User, "Say hello in 5 words")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            });

        Console.WriteLine(response.Text);

        response.Text.Should().NotBeNullOrEmpty();
        response.ModelId.Should().NotBeNullOrEmpty();
        response.Usage.Should().NotBeNull();
        response.Usage!.InputTokenCount.Should().BeGreaterThan(0);
        response.Usage.OutputTokenCount.Should().BeGreaterThan(0);
    }
}
