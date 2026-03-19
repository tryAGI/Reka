# Translate Audio



This example assumes `using Reka;` is in scope and `apiKey` contains your Reka API key.

```csharp
using var api = new RekaClient(apiKey);

var response = await api.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = TestAudioUrl,
    SamplingRate = 16000,
    TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
    IsTranslate = true,
});

Console.WriteLine($"Transcript: {response.Transcript}");
Console.WriteLine($"Translation: {response.Translation}");

// Note: transcript_translation_with_timestamp may not be returned for translations
```