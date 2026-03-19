/*
order: 430
title: Research With Parallel Thinking
slug: research-with-parallel-thinking
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Research_WithParallelThinking()
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
                    Content = "Explain the theory of relativity in simple terms",
                },
            ],
            MaxTokens = 512,
            Research = new ResearchConfig
            {
                WebSearch = new WebSearchConfig
                {
                    Enabled = true,
                },
                ParallelThinking = new ParallelThinkingConfig
                {
                    Mode = ParallelThinkingConfigMode.Low,
                },
            },
        });

        Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();

        if (response.Choices[0].Message.ReasoningContent is not null)
        {
            Console.WriteLine($"Reasoning content: {response.Choices[0].Message.ReasoningContent}");
        }
    }
}
