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

    [TestMethod]
    public async Task ChatClient_ToolCalling_RequiredMode()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var getTimeTool = AIFunctionFactory.Create(
            (string timezone) => $"The current time in {timezone} is 2:30 PM.",
            "get_time",
            "Gets the current time in a timezone");

        var response = await chatClient.GetResponseAsync(
            [new ChatMessage(ChatRole.User, "Hello!")],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 256,
                Tools = [getTimeTool],
                ToolMode = ChatToolMode.RequireAny,
            });

        Console.WriteLine($"Finish reason: {response.FinishReason}");

        // With required tool mode, the model should always produce a tool call
        response.FinishReason.Should().Be(ChatFinishReason.ToolCalls);

        var functionCalls = response.Messages
            .SelectMany(m => m.Contents)
            .OfType<FunctionCallContent>()
            .ToList();

        functionCalls.Should().NotBeEmpty();
    }
}
