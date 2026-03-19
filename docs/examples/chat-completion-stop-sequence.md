# Chat Completion Stop Sequence



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
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
```