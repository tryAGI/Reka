/*
order: 490
title: Speech To Text Client Get Text Async
slug: speech-to-text-client-get-text-async
*/

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
}
