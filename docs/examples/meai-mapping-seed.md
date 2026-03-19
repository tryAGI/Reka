# Meai Mapping Seed



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-flash",
            Seed = 42,
        });
}
catch { }

var body = capture.LastRequestBody!.RootElement;
```