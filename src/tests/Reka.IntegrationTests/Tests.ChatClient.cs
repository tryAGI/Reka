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

    [TestMethod]
    public async Task ChatClient_GetStreamingResponseAsync()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var allText = new System.Text.StringBuilder();
        var updateCount = 0;
        string? responseId = null;
        string? modelId = null;
        ChatFinishReason? finishReason = null;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new(ChatRole.User, "Count from 1 to 5")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            }))
        {
            updateCount++;
            responseId ??= update.ResponseId;
            modelId ??= update.ModelId;
            finishReason = update.FinishReason ?? finishReason;

            if (update.Text is not null)
            {
                allText.Append(update.Text);
            }
        }

        Console.WriteLine($"Received {updateCount} chunks");
        Console.WriteLine($"Full text: {allText}");

        updateCount.Should().BeGreaterThan(1, "streaming should produce multiple chunks");
        allText.Length.Should().BeGreaterThan(0);
        responseId.Should().NotBeNullOrEmpty();
        modelId.Should().NotBeNullOrEmpty();
        finishReason.Should().Be(ChatFinishReason.Stop);
    }
}
