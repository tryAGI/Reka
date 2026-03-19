/*
order: 230
title: Chat Completion Max Tokens One
slug: chat-completion-max-tokens-one
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_MaxTokensOne()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Model = "reka-flash",
            Messages =
            [
                new ChatMessageInput
                {
                    Role = ChatMessageInputRole.User,
                    Content = "Write a very long essay about the history of computing",
                },
            ],
            MaxTokens = 1,
        });

        Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
        Console.WriteLine($"Finish reason: {response.Choices[0].FinishReason}");

        response.Choices.Should().NotBeEmpty();
        // With max_tokens=1, the model should hit the length limit
        response.Choices[0].FinishReason.Should().Be(ChoiceFinishReason.Length);
    }
}
