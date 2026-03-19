# Chat Completion System Message As User



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
// Reka doesn't support system role — verify it works when passed through IChatClient
// (system messages should be converted to user messages)
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.System, "You are a pirate. Always respond in pirate speak."),
        new ChatMessage(ChatRole.User, "Say hello"),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```