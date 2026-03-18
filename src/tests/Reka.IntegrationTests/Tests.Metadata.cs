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

    [TestMethod]
    public void ChatClient_GetService_Self()
    {
        using var api = new RekaClient("dummy-key");
        MeaiChatClient chatClient = api;

        var self = chatClient.GetService<RekaClient>();

        self.Should().NotBeNull();
        self.Should().BeSameAs(api);
    }

    [TestMethod]
    public void SpeechToTextClient_GetService_Metadata()
    {
        using var api = new RekaClient("dummy-key");
        MeaiSpeechToTextClient speechClient = api;

        var metadata = speechClient.GetService<SpeechToTextClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(RekaClient));
        metadata.ProviderUri.Should().NotBeNull();
        metadata.ProviderUri!.ToString().Should().Contain("reka.ai");
    }

    [TestMethod]
    public void SpeechToTextClient_GetService_Self()
    {
        using var api = new RekaClient("dummy-key");
        MeaiSpeechToTextClient speechClient = api;

        var self = speechClient.GetService<RekaClient>();

        self.Should().NotBeNull();
        self.Should().BeSameAs(api);
    }

    [TestMethod]
    public void ChatClient_GetService_UnknownReturnsNull()
    {
        using var api = new RekaClient("dummy-key");
        MeaiChatClient chatClient = api;

        var unknown = chatClient.GetService<string>();

        unknown.Should().BeNull();
    }
}
