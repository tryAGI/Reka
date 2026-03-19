/*
order: 530
title: Translate Audio
slug: translate-audio
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TranslateAudio()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
        {
            AudioUrl = TestAudioUrl,
            SamplingRate = 16000,
            TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
            IsTranslate = true,
        });

        Console.WriteLine($"Transcript: {response.Transcript}");
        Console.WriteLine($"Translation: {response.Translation}");

        response.Transcript.Should().NotBeNullOrEmpty();
        response.Translation.Should().NotBeNullOrEmpty();
        // Note: transcript_translation_with_timestamp may not be returned for translations
    }
}
