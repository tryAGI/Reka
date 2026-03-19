# Chat Completion Temperature



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

// Temperature 0 should produce deterministic output
var response = await api.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is 2+2? Answer with just the number.",
        },
    ],
    MaxTokens = 16,
    Temperature = 0.0,
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");
```