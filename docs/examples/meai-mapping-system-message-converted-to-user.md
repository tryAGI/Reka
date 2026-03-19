# Meai Mapping System Message Converted To User



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.System, "You are a helpful assistant."),
            new ChatMessage(ChatRole.User, "Hello"),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { /* expected — mock returns error */ }

var body = capture.LastRequestBody;

var messages = body!.RootElement.GetProperty("messages");
```