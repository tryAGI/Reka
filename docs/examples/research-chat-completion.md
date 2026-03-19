# Research Chat Completion



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is the capital of France?",
        },
    ],
    MaxTokens = 256,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
```