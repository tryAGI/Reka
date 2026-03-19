/*
order: 420
title: Research Chat Completion
slug: research-chat-completion
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Research_ChatCompletion()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
        {
            Model = "reka-flash-research",
            Messages =
            [
                new ChatMessageInput
                {
                    Role = ChatMessageInputRole.User,
                    Content = "What is the capital of France?",
                },
            ],
            MaxTokens = 256,
        });

        Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();
    }
}
