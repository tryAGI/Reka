# Speech To Text Client Get Text Async



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Download a small WAV file and pass as stream
using var httpClient = new HttpClient();
await using var audioStream = await httpClient.GetStreamAsync(
    TestAudioUrl);

// Buffer into MemoryStream since the API needs to convert to base64
var ms = new MemoryStream();
await audioStream.CopyToAsync(ms);
ms.Position = 0;

var response = await speechClient.GetTextAsync(ms);

Console.WriteLine($"Text: {response.Text}");
```