# Chat Client Audio Url



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What language is spoken in this audio? Answer in one word."),
            new UriContent(new Uri(TestAudioUrl), "audio/wav"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```