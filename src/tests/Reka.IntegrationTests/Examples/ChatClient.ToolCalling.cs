/*
order: 200
title: Chat Client Tool Calling
slug: chat-client-tool-calling
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var getWeatherTool = AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is 72°F and sunny.",
            "get_weather",
            "Gets the current weather for a location");

        List<ChatMessage> messages =
        [
            new(ChatRole.User, "What's the weather like in San Francisco?"),
        ];

        var response = await chatClient.GetResponseAsync(
            messages,
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 256,
                Tools = [getWeatherTool],
            });

        Console.WriteLine($"Finish reason: {response.FinishReason}");

        // The model should request a tool call
        response.FinishReason.Should().Be(ChatFinishReason.ToolCalls);

        var functionCalls = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<FunctionCallContent>()
            .ToList();

        functionCalls.Should().NotBeEmpty("model should generate at least one tool call");

        var toolCall = functionCalls[0];
        Console.WriteLine($"Tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");

        toolCall.Name.Should().Be("get_weather");
        toolCall.Arguments.Should().ContainKey("location");
    }
}
