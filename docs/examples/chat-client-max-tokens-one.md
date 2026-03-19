# Chat Client Max Tokens One



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
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
```