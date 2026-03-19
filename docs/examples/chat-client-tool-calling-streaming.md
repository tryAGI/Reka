# Chat Client Tool Calling Streaming



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
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

// Check that tool calls were emitted
var functionCalls = updates
    .SelectMany(u => u.Contents)
    .OfType<FunctionCallContent>()
    .ToList();

var toolCall = functionCalls[0];
Console.WriteLine($"Streaming tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");

// Check finish reason
var finishReason = updates.LastOrDefault(u => u.FinishReason is not null)?.FinishReason;
```