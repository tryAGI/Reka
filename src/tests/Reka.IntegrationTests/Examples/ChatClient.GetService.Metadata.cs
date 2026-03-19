/*
order: 50
title: Chat Client Get Service Metadata
slug: chat-client-get-service-metadata
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_Metadata()
    {
        // These tests don't need a real API key — metadata is local-only
        using var api = new RekaClient("dummy-key");
        MeaiChatClient chatClient = api;

        var metadata = chatClient.GetService<ChatClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(RekaClient));
        metadata.ProviderUri.Should().NotBeNull();
        metadata.ProviderUri!.ToString().Should().Contain("reka.ai");
    }
}
