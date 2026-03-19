# Meai Mapping Default Model



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        options: null);
}
catch { }

capture.LastRequestBody!.RootElement
```