# Chat Client Tool Calling Required Mode



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
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

var functionCalls = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<FunctionCallContent>()
    .ToList();
```