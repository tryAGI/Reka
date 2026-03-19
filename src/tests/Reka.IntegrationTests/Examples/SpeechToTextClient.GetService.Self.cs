/*
order: 470
title: Speech To Text Client Get Service Self
slug: speech-to-text-client-get-service-self
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Self()
    {
        using var api = new RekaClient("dummy-key");
        MeaiSpeechToTextClient speechClient = api;

        var self = speechClient.GetService<RekaClient>();

        self.Should().NotBeNull();
        self.Should().BeSameAs(api);
    }
}
