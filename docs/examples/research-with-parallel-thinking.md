# Research With Parallel Thinking



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
            Content = "Explain the theory of relativity in simple terms",
        },
    ],
    MaxTokens = 512,
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig
        {
            Enabled = true,
        },
        ParallelThinking = new ParallelThinkingConfig
        {
            Mode = ParallelThinkingConfigMode.Low,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

if (response.Choices[0].Message.ReasoningContent is not null)
{
    Console.WriteLine($"Reasoning content: {response.Choices[0].Message.ReasoningContent}");
}
```