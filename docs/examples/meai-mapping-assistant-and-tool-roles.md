# Meai Mapping Assistant And Tool Roles



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [
            new ChatMessage(ChatRole.User, "Hello"),
            new ChatMessage(ChatRole.Assistant, "Hi!"),
            new ChatMessage(ChatRole.Tool,
            [
                new FunctionResultContent("call_123", "result data"),
            ]),
        ],
        new ChatOptions { ModelId = "reka-flash" });
}
catch { }

var messages = capture.LastRequestBody!.RootElement.GetProperty("messages");
// Reka doesn't support tool_call_id on user messages — tool result is formatted as text
```