/*
order: 180
title: Chat Client Tool Calling Round Trip
slug: chat-client-tool-calling-round-trip
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_RoundTrip()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var getWeatherTool = AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is 72°F and sunny.",
            "get_weather",
            "Gets the current weather for a location");

        List<ChatMessage> messages =
        [
            new(ChatRole.User, "What's the weather like in San Francisco? Use the tool to find out."),
        ];

        var options = new ChatOptions
        {
            ModelId = "reka-flash",
            MaxOutputTokens = 256,
            Tools = [getWeatherTool],
        };

        // First call: model should request tool
        var response = await chatClient.GetResponseAsync(messages, options);

        Console.WriteLine($"First response finish reason: {response.FinishReason}");
        response.FinishReason.Should().Be(ChatFinishReason.ToolCalls);

        // Add assistant message with tool calls to conversation
        messages.AddRange(response.Messages);

        // Process each tool call and add results
        foreach (var functionCall in response.Messages
                     .SelectMany(m => m.Contents)
                     .OfType<FunctionCallContent>())
        {
            var result = await getWeatherTool.InvokeAsync(
                new AIFunctionArguments(functionCall.Arguments ?? new Dictionary<string, object?>()));

            messages.Add(new ChatMessage(ChatRole.Tool,
            [
                new FunctionResultContent(functionCall.CallId, result),
            ]));
        }

        // Second call: model should use tool result to answer
        // Remove tools to prevent re-calling (Reka sends tool results as user messages)
        var followUpOptions = new ChatOptions
        {
            ModelId = options.ModelId,
            MaxOutputTokens = options.MaxOutputTokens,
        };
        var finalResponse = await chatClient.GetResponseAsync(messages, followUpOptions);

        Console.WriteLine($"Final response: {finalResponse.Text}");
        Console.WriteLine($"Final finish reason: {finalResponse.FinishReason}");

        finalResponse.FinishReason.Should().Be(ChatFinishReason.Stop);
        finalResponse.Text.Should().NotBeNullOrEmpty();
        finalResponse.Text.Should().Contain("72", "response should reference the weather data from the tool");
    }
}
