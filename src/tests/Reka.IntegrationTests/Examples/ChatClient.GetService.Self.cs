/*
order: 60
title: Chat Client Get Service Self
slug: chat-client-get-service-self
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_Self()
    {
        using var api = new RekaClient("dummy-key");
        MeaiChatClient chatClient = api;

        var self = chatClient.GetService<RekaClient>();

        self.Should().NotBeNull();
        self.Should().BeSameAs(api);
    }
}
