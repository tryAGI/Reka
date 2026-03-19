# Chat Client Get Streaming Response Async



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var allText = new System.Text.StringBuilder();
var updateCount = 0;
string? responseId = null;
string? modelId = null;
ChatFinishReason? finishReason = null;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [new(ChatRole.User, "Count from 1 to 5")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 64,
    }))
{
    updateCount++;
    responseId ??= update.ResponseId;
    modelId ??= update.ModelId;
    finishReason = update.FinishReason ?? finishReason;

    if (update.Text is not null)
    {
        allText.Append(update.Text);
    }
}

Console.WriteLine($"Received {updateCount} chunks");
Console.WriteLine($"Full text: {allText}");
```