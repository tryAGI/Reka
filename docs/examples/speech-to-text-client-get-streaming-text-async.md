# Speech To Text Client Get Streaming Text Async



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    TestAudioUrl);

var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var updates = new List<SpeechToTextResponseUpdate>();
await foreach (var update in speechClient.GetStreamingTextAsync(ms))
{
    updates.Add(update);
    Console.WriteLine($"Update: {update.Text}");
}
```