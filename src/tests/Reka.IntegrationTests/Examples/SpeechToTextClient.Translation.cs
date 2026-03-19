/*
order: 500
title: Speech To Text Client Translation
slug: speech-to-text-client-translation
*/

using Microsoft.Extensions.AI;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
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
