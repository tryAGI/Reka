# Chat Client Data Content Image



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

// Download image and send as inline DataContent (base64)
using var httpClient = new HttpClient();
var imageBytes = await httpClient.GetByteArrayAsync(TestImageUrl);

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new DataContent(imageBytes, "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine($"Response: {response.Text}");
```