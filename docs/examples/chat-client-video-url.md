# Chat Client Video Url



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this video? Answer in one sentence."),
            new UriContent(new Uri(TestVideoUrl), "video/webm"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```