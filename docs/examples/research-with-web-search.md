# Research With Web Search



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
            Content = "What is the current weather in Tokyo?",
        },
    ],
    MaxTokens = 512,
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig
        {
            Enabled = true,
            MaxUses = 3,
        },
    },
});

Console.WriteLine($"Content: {response.Choices[0].Message.Content}");

// Research model may return reasoning steps and annotations
if (response.Choices[0].Message.ReasoningSteps is { Count: > 0 } steps)
{
    Console.WriteLine($"Reasoning steps: {steps.Count}");
    foreach (var step in steps)
    {
        Console.WriteLine($"  Step role={step.Role}: {step.ReasoningContent ?? step.Content}");
    }
}

if (response.Choices[0].Message.Annotations is { Count: > 0 } annotations)
{
    Console.WriteLine($"Annotations: {annotations.Count}");
    foreach (var annotation in annotations)
    {
        Console.WriteLine($"  Citation: {annotation.UrlCitation?.Title} - {annotation.UrlCitation?.Url}");
    }
}
```