/*
order: 220
title: Chat Completion Invalid Model
slug: chat-completion-invalid-model
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_InvalidModel()
    {
        using var api = GetAuthenticatedClient();

        var action = () => api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Model = "nonexistent-model-12345",
            Messages =
            [
                new ChatMessageInput
                {
                    Role = ChatMessageInputRole.User,
                    Content = "Hello",
                },
            ],
            MaxTokens = 16,
        });

        await action.Should().ThrowAsync<Exception>();
    }
}
