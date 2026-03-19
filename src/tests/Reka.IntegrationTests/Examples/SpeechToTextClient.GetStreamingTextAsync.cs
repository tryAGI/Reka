/*
order: 480
title: Speech To Text Client Get Streaming Text Async
slug: speech-to-text-client-get-streaming-text-async
*/

using Microsoft.Extensions.AI;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
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
}
