/*
order: 110
title: Chat Client Invalid Model
slug: chat-client-invalid-model
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_InvalidModel()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var action = () => chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Hello")],
            new ChatOptions
            {
                ModelId = "nonexistent-model-12345",
                MaxOutputTokens = 16,
            });

        await action.Should().ThrowAsync<Exception>();
    }
}
