# Chat Client Image Url



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```