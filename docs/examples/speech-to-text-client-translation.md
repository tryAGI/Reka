# Speech To Text Client Translation



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);
MeaiSpeechToTextClient speechClient = api;

// Use RawRepresentationFactory to configure translation via target_language
var options = new SpeechToTextOptions
{
    RawRepresentationFactory = _ => new TranscribeOrTranslateRequest
    {
        AudioUrl = TestAudioUrl,
        SamplingRate = 16000,
        TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
        IsTranslate = true,
    },
};

using var emptyStream = new MemoryStream();
var response = await speechClient.GetTextAsync(emptyStream, options);

Console.WriteLine($"Transcript: {response.Text}");

// Verify the underlying response has the translation
var rawResponse = (TranscribeOrTranslateResponse)response.RawRepresentation!;
Console.WriteLine($"Translation: {rawResponse.Translation}");
```