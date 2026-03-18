using Microsoft.Extensions.AI;

using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetTextAsync()
    {
        using var api = GetAuthenticatedClient();
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

        response.Text.Should().NotBeNullOrEmpty();
        response.RawRepresentation.Should().NotBeNull();
        response.RawRepresentation.Should().BeOfType<TranscribeOrTranslateResponse>();
    }

    [TestMethod]
    public async Task SpeechToTextClient_GetStreamingTextAsync()
    {
        using var api = GetAuthenticatedClient();
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

        updates.Should().NotBeEmpty();
        updates.Any(u => !string.IsNullOrEmpty(u.Text)).Should().BeTrue();
    }

    [TestMethod]
    public async Task SpeechToTextClient_WithRawRepresentationFactory()
    {
        using var api = GetAuthenticatedClient();
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

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task SpeechToTextClient_Translation()
    {
        using var api = GetAuthenticatedClient();
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

        response.Text.Should().NotBeNullOrEmpty();
        response.RawRepresentation.Should().BeOfType<TranscribeOrTranslateResponse>();

        // Verify the underlying response has the translation
        var rawResponse = (TranscribeOrTranslateResponse)response.RawRepresentation!;
        Console.WriteLine($"Translation: {rawResponse.Translation}");
        rawResponse.Translation.Should().NotBeNullOrEmpty();
    }
}
