# Chat Client Tool Calling



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
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

var functionCalls = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .ToList();

var toolCall = functionCalls[0];
Console.WriteLine($"Tool call: {toolCall.Name}({string.Join(", ", toolCall.Arguments?.Select(kv => $"{kv.Key}={kv.Value}") ?? [])})");
```