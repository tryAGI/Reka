/*
order: 520
title: Transcribe Audio
slug: transcribe-audio
*/

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TranscribeAudio()
    {
        using var api = GetAuthenticatedClient();

        var response = await api.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
        {
            AudioUrl = TestAudioUrl,
            SamplingRate = 16000,
        });

        Console.WriteLine($"Transcript: {response.Transcript}");

        response.Transcript.Should().NotBeNullOrEmpty();
        response.TranscriptTranslationWithTimestamp.Should().NotBeEmpty();
    }
}
