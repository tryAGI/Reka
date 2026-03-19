# Chat Client Seed Reproducibility



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var options = new ChatOptions
{
    ModelId = "reka-flash",
    MaxOutputTokens = 32,
    Temperature = 0,
    Seed = 42,
};

var response1 = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
    options);

var response2 = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Say exactly: 'Hello World 123'")],
    options);

Console.WriteLine($"Response 1: {response1.Text}");
Console.WriteLine($"Response 2: {response2.Text}");

// With same seed and temperature=0, outputs should be identical
```