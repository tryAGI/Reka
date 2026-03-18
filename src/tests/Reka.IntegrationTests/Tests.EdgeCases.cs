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

    [TestMethod]
    public async Task ChatClient_MaxTokensOne()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Write a very long essay about the history of computing")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 1,
            });

        Console.WriteLine($"Text: {response.Text}");
        Console.WriteLine($"Finish reason: {response.FinishReason}");

        response.FinishReason.Should().Be(ChatFinishReason.Length);
    }

    [TestMethod]
    public async Task ChatCompletion_SystemMessageAsUser()
    {
        // Reka doesn't support system role — verify it works when passed through IChatClient
        // (system messages should be converted to user messages)
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.System, "You are a pirate. Always respond in pirate speak."),
                new ChatMessage(ChatRole.User, "Say hello"),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

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

    [TestMethod]
    public async Task ChatCompletion_StopSequence()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Count from 1 to 10, separated by commas")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
                StopSequences = ["5"],
            });

        Console.WriteLine($"Response: {response.Text}");

        // The response should stop before or at "5"
        response.Text.Should().NotBeNullOrEmpty();
        response.Text.Should().NotContain("6", "output should stop before reaching 6");
    }
}
