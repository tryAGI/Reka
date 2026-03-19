# Chat Client Data Content Audio



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

// Download audio and send as inline DataContent (base64)
using var httpClient = new HttpClient();
var audioBytes = await httpClient.GetByteArrayAsync(TestAudioUrl);

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What language is spoken in this audio? Answer in one word."),
            new DataContent(audioBytes, "audio/wav"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    });

Console.WriteLine($"Response: {response.Text}");
```