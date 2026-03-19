# Chat Client Get Response Async



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [new(ChatRole.User, "Say hello in 5 words")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine(response.Text);
```