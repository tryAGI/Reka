# Chat Client Multiple Content Parts



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("Describe what you see."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
            new TextContent("Now summarize in exactly 3 words."),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```