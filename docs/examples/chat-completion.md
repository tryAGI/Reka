# Chat Completion



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
            Content = "Say hello in 5 words",
        },
    ],
    MaxTokens = 64,
});

Console.WriteLine(response.Choices[0].Message.Content);
```