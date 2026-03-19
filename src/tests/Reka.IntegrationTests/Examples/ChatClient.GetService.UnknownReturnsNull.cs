/*
order: 70
title: Chat Client Get Service Unknown Returns Null
slug: chat-client-get-service-unknown-returns-null
*/

using Microsoft.Extensions.AI;
using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using MeaiSpeechToTextClient = Microsoft.Extensions.AI.ISpeechToTextClient;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_UnknownReturnsNull()
    {
        using var api = new RekaClient("dummy-key");
        MeaiChatClient chatClient = api;

        var unknown = chatClient.GetService<string>();

        unknown.Should().BeNull();
    }
}
