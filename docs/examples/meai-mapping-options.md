# Meai Mapping Options



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
var (client, capture) = CreateCapturingClient();
using var _ = client;
MeaiChatClient chatClient = client;

try
{
    await chatClient.GetResponseAsync(
        [new ChatMessage(ChatRole.User, "Hello")],
        new ChatOptions
        {
            ModelId = "reka-core",
            MaxOutputTokens = 512,
            Temperature = 0.7f,
            TopP = 0.9f,
            TopK = 50,
            FrequencyPenalty = 0.5f,
            PresencePenalty = 0.3f,
            StopSequences = ["END", "STOP"],
        });
}
catch { }

var root = capture.LastRequestBody!.RootElement;
```