# Speech To Text Client With Raw Representation Factory



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Use RawRepresentationFactory to pass a pre-configured request with a URL
var options = new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new TranscribeOrTranslateRequest
    {
        AudioUrl = TestAudioUrl,
        SamplingRate = 16000,
    },
};

// Pass an empty stream since URL is provided via factory
using var emptyStream = new MemoryStream();
var response = await speechClient.GetTextAsync(emptyStream, options);

Console.WriteLine($"Text: {response.Text}");
```