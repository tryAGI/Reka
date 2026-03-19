# Meai Mapping Multiple Text Contents Switch To Parts



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
                new TextContent("First"),
                new TextContent("Second"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var content = capture.LastRequestBody!.RootElement
    .GetProperty("messages")[0].GetProperty("content");
```