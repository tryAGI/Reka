# Meai Mapping Data Content Audio



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
                new TextContent("Transcribe"),
                new DataContent(new byte[] { 0x52, 0x49, 0x46, 0x46 }, "audio/wav"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var parts = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```