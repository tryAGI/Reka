/*
order: 450
title: Research With Web Search
slug: research-with-web-search
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Research_WithWebSearch()
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
                    Content = "What is the current weather in Tokyo?",
                },
            ],
            MaxTokens = 512,
            Research = new ResearchConfig
            {
                WebSearch = new WebSearchConfig
                {
                    Enabled = true,
                    MaxUses = 3,
                },
            },
        });

        Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

        response.Choices.Should().NotBeEmpty();
        response.Choices[0].Message.Content.Should().NotBeNullOrEmpty();

        // Research model may return reasoning steps and annotations
        if (response.Choices[0].Message.ReasoningSteps is { Count: > 0 } steps)
        {
            Console.WriteLine($"Reasoning steps: {steps.Count}");
            foreach (var step in steps)
            {
                Console.WriteLine($"  Step role={step.Role}: {step.ReasoningContent ?? step.Content}");
            }
        }

        if (response.Choices[0].Message.Annotations is { Count: > 0 } annotations)
        {
            Console.WriteLine($"Annotations: {annotations.Count}");
            foreach (var annotation in annotations)
            {
                Console.WriteLine($"  Citation: {annotation.UrlCitation?.Title} - {annotation.UrlCitation?.Url}");
            }
        }
    }
}
