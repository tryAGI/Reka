# Chat Client Invalid Model



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var action = () => chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello")],
    new ChatOptions
    {
        ModelId = "nonexistent-model-12345",
        MaxOutputTokens = 16,
    });
```