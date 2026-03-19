/*
order: 190
title: Chat Client Tool Calling Streaming
slug: chat-client-tool-calling-streaming
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Ignore("Reka API returns empty stream when tools are present")]
    public async Task ChatClient_ToolCalling_Streaming()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var getWeatherTool = AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is 72°F and sunny.",
            "get_weather",
            "Gets the current weather for a location");

        var updates = new List<Microsoft.Extensions.AI.ChatResponseUpdate>();
        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [new ChatMessage(ChatRole.User, "What's the weather like in San Francisco?")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 256,
                Tools = [getWeatherTool],
            }))
        {
            updates.Add(update);
        }

        updates.Should().NotBeEmpty();

        // Check that tool calls were emitted
        var functionCalls = updates
            .SelectMany(u => u.Contents)
            .OfType<FunctionCallContent>()
            .ToList();

        functionCalls.Should().NotBeEmpty("streaming should emit tool calls");

        var toolCall = functionCalls[0];
        Console.WriteLine($"Streaming tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");

        toolCall.Name.Should().Be("get_weather");
        toolCall.Arguments.Should().ContainKey("location");

        // Check finish reason
        var finishReason = updates.LastOrDefault(u => u.FinishReason is not null)?.FinishReason;
        finishReason.Should().Be(ChatFinishReason.ToolCalls);
    }
}
