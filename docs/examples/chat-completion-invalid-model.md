# Chat Completion Invalid Model



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var action = () => api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "nonexistent-model-12345",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Hello",
        },
    ],
    MaxTokens = 16,
});
```