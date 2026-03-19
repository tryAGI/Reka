# Meai Mapping Video Uri Content



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User,
            [
                new TextContent("Describe video"),
                new UriContent(new Uri("https://example.com/video.mp4"), "video/mp4"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```