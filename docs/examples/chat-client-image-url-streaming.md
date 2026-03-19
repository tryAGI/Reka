# Chat Client Image Url Streaming



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiChatClient chatClient = api;

var allText = new System.Text.StringBuilder();
var updateCount = 0;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image? Answer in one sentence."),
            new UriContent(new Uri(TestImageUrl), "image/png"),
        ]),
    ],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    }))
{
    updateCount++;
    if (update.Text is not null)
    {
        allText.Append(update.Text);
    }
}

Console.WriteLine($"Received {updateCount} chunks");
Console.WriteLine($"Full text: {allText}");
```