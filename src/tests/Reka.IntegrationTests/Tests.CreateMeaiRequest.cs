using System.Text.Json;
using Microsoft.Extensions.AI;

using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

/// <summary>
/// Tests that verify the MEAI → Reka request mapping logic
/// by intercepting the HTTP request before it reaches the API.
/// </summary>
public partial class Tests
{
    private static (RekaClient client, RequestCapture capture) CreateCapturingClient()
    {
        var capture = new RequestCapture();
        var httpClient = new HttpClient(capture)
        {
            BaseAddress = new Uri("https://api.reka.ai"),
        };

        var client = new RekaClient(
            apiKey: "dummy-key",
            httpClient: httpClient,
            disposeHttpClient: false);
        return (client, capture);
    }

    [TestMethod]
    public async Task MeaiMapping_SystemMessageConvertedToUser()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.System, "You are a helpful assistant."),
                    new ChatMessage(ChatRole.User, "Hello"),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { /* expected — mock returns error */ }

        var body = capture.LastRequestBody;
        body.Should().NotBeNull();

        var messages = body!.RootElement.GetProperty("messages");
        messages.GetArrayLength().Should().Be(1, "system text should be prepended to the user message");
        messages[0].GetProperty("role").GetString().Should().Be("user");
        messages[0].GetProperty("content").GetString().Should().Contain("You are a helpful assistant.");
        messages[0].GetProperty("content").GetString().Should().Contain("Hello");
    }

    [TestMethod]
    public async Task MeaiMapping_DefaultModel()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                options: null);
        }
        catch { }

        capture.LastRequestBody!.RootElement
            .GetProperty("model").GetString().Should().Be("reka-flash");
    }

    [TestMethod]
    public async Task MeaiMapping_Options()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                new ChatOptions
                {
                    ModelId = "reka-core",
                    MaxOutputTokens = 512,
                    Temperature = 0.7f,
                    TopP = 0.9f,
                    TopK = 50,
                    FrequencyPenalty = 0.5f,
                    PresencePenalty = 0.3f,
                    StopSequences = ["END", "STOP"],
                });
        }
        catch { }

        var root = capture.LastRequestBody!.RootElement;
        root.GetProperty("model").GetString().Should().Be("reka-core");
        root.GetProperty("max_tokens").GetInt32().Should().Be(512);
        root.GetProperty("temperature").GetDouble().Should().BeApproximately(0.7, 0.01);
        root.GetProperty("top_p").GetDouble().Should().BeApproximately(0.9, 0.01);
        root.GetProperty("top_k").GetInt32().Should().Be(50);
        root.GetProperty("frequency_penalty").GetDouble().Should().BeApproximately(0.5, 0.01);
        root.GetProperty("presence_penalty").GetDouble().Should().BeApproximately(0.3, 0.01);
        root.GetProperty("stop").GetArrayLength().Should().Be(2);
    }

    [TestMethod]
    public async Task MeaiMapping_ImageUriContent()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Describe this"),
                        new UriContent(new Uri("https://example.com/image.png"), "image/png"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts.GetArrayLength().Should().Be(2);
        parts[0].GetProperty("type").GetString().Should().Be("text");
        parts[1].GetProperty("type").GetString().Should().Be("image_url");
        parts[1].GetProperty("image_url").GetString().Should().Be("https://example.com/image.png");
    }

    [TestMethod]
    public async Task MeaiMapping_AudioUriContent()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Transcribe"),
                        new UriContent(new Uri("https://example.com/audio.wav"), "audio/wav"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("audio_url");
        parts[1].GetProperty("audio_url").GetString().Should().Be("https://example.com/audio.wav");
    }

    [TestMethod]
    public async Task MeaiMapping_VideoUriContent()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Describe video"),
                        new UriContent(new Uri("https://example.com/video.mp4"), "video/mp4"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("video_url");
    }

    [TestMethod]
    public async Task MeaiMapping_PdfUriContent()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Summarize"),
                        new UriContent(new Uri("https://example.com/doc.pdf"), "application/pdf"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("pdf_url");
    }

    [TestMethod]
    public async Task MeaiMapping_DataContentImage()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("What is this?"),
                        new DataContent(new byte[] { 0x89, 0x50, 0x4E, 0x47 }, "image/png"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("image_url");
        parts[1].GetProperty("image_url").GetString().Should().StartWith("data:image/png;base64,");
    }

    [TestMethod]
    public async Task MeaiMapping_DataContentAudio()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("Transcribe"),
                        new DataContent(new byte[] { 0x52, 0x49, 0x46, 0x46 }, "audio/wav"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var parts = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        parts[1].GetProperty("type").GetString().Should().Be("audio_url");
        parts[1].GetProperty("audio_url").GetString().Should().StartWith("data:audio/wav;base64,");
    }

    [TestMethod]
    public async Task MeaiMapping_MultipleTextContentsSwitchToParts()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User,
                    [
                        new TextContent("First"),
                        new TextContent("Second"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var content = capture.LastRequestBody!.RootElement
            .GetProperty("messages")[0].GetProperty("content");
        content.ValueKind.Should().Be(JsonValueKind.Array);
        content.GetArrayLength().Should().Be(2);
        content[0].GetProperty("text").GetString().Should().Be("First");
        content[1].GetProperty("text").GetString().Should().Be("Second");
    }

    [TestMethod]
    public async Task MeaiMapping_AssistantAndToolRoles()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [
                    new ChatMessage(ChatRole.User, "Hello"),
                    new ChatMessage(ChatRole.Assistant, "Hi!"),
                    new ChatMessage(ChatRole.Tool,
                    [
                        new FunctionResultContent("call_123", "result data"),
                    ]),
                ],
                new ChatOptions { ModelId = "reka-flash" });
        }
        catch { }

        var messages = capture.LastRequestBody!.RootElement.GetProperty("messages");
        messages.GetArrayLength().Should().Be(3);
        messages[0].GetProperty("role").GetString().Should().Be("user");
        messages[1].GetProperty("role").GetString().Should().Be("assistant");
        messages[2].GetProperty("role").GetString().Should().Be("user", "Reka maps tool role to user");
        // Reka doesn't support tool_call_id on user messages — tool result is formatted as text
        messages[2].GetProperty("content").GetString().Should().Contain("[Tool result for call_123]");
    }

    [TestMethod]
    public async Task MeaiMapping_ResponseFormatJson()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        var schema = JsonSerializer.Deserialize<JsonElement>("""
            {
                "type": "object",
                "properties": {
                    "answer": { "type": "string" }
                },
                "required": ["answer"]
            }
            """);

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                new ChatOptions
                {
                    ModelId = "reka-flash",
                    ResponseFormat = ChatResponseFormat.ForJsonSchema(schema, "test_schema", "A test schema"),
                });
        }
        catch { }

        var body = capture.LastRequestBody!.RootElement;
        var rf = body.GetProperty("response_format");
        rf.GetProperty("type").GetString().Should().Be("json_schema");
        rf.GetProperty("json_schema").GetProperty("name").GetString().Should().Be("test_schema");
        rf.GetProperty("json_schema").GetProperty("description").GetString().Should().Be("A test schema");
        rf.GetProperty("json_schema").GetProperty("schema").GetProperty("type").GetString().Should().Be("object");
    }

    [TestMethod]
    public async Task MeaiMapping_Seed()
    {
        var (client, capture) = CreateCapturingClient();
        using var _ = client;
        MeaiChatClient chatClient = client;

        try
        {
            await chatClient.GetResponseAsync(
                [new ChatMessage(ChatRole.User, "Hello")],
                new ChatOptions
                {
                    ModelId = "reka-flash",
                    Seed = 42,
                });
        }
        catch { }

        var body = capture.LastRequestBody!.RootElement;
        body.GetProperty("seed").GetInt32().Should().Be(42);
    }
}

/// <summary>
/// HTTP handler that captures request bodies without sending them.
/// Returns a 400 error so the client throws — we only care about the request.
/// </summary>
internal sealed class RequestCapture : HttpMessageHandler
{
    public JsonDocument? LastRequestBody { get; private set; }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.Content is not null)
        {
            var json = await request.Content.ReadAsStringAsync(cancellationToken);
            LastRequestBody = JsonDocument.Parse(json);
        }

        return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
        {
            Content = new StringContent("{\"detail\":\"test capture\"}"),
        };
    }
}
