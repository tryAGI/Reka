# Chat Completion Max Tokens One



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Write a very long essay about the history of computing",
        },
    ],
    MaxTokens = 1,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
Console.WriteLine($"Finish reason: {response.Choices[0].FinishReason}");

// With max_tokens=1, the model should hit the length limit
```