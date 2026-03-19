/*
order: 510
title: Speech To Text Client With Raw Representation Factory
slug: speech-to-text-client-with-raw-representation-factory
*/

using Microsoft.Extensions.AI;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
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
}
