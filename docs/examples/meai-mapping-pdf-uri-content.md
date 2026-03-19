# Meai Mapping Pdf Uri Content



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
                new TextContent("Summarize"),
                new UriContent(new Uri("https://example.com/doc.pdf"), "application/pdf"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```