/*
order: 260
title: Chat Completion Temperature
slug: chat-completion-temperature
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatCompletion_Temperature()
    {
        using var api = GetAuthenticatedClient();

        // Temperature 0 should produce deterministic output
        var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Model = "reka-flash",
            Messages =
            [
                new ChatMessageInput
                {
                    Role = ChatMessageInputRole.User,
                    Content = "What is 2+2? Answer with just the number.",
                },
            ],
            MaxTokens = 16,
            Temperature = 0.0,
        });

        Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

        response.Choices[0].Message.Content.Should().Contain("4");
    }
}
