using Microsoft.Extensions.AI;

using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;
using ChatMessage = Microsoft.Extensions.AI.ChatMessage;

namespace Reka.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ImageUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this image? Answer in one sentence."),
                    new UriContent(new Uri(TestImageUrl), "image/png"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_AudioUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What language is spoken in this audio? Answer in one word."),
                    new UriContent(new Uri(TestAudioUrl), "audio/wav"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_PdfUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What does this PDF document contain? Answer in one sentence."),
                    new UriContent(new Uri(TestPdfUrl), "application/pdf"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_VideoUrl()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this video? Answer in one sentence."),
                    new UriContent(new Uri(TestVideoUrl), "video/webm"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_MultipleContentParts()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("Describe what you see."),
                    new UriContent(new Uri(TestImageUrl), "image/png"),
                    new TextContent("Now summarize in exactly 3 words."),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_ImageUrl_Streaming()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        var allText = new System.Text.StringBuilder();
        var updateCount = 0;

        await foreach (var update in chatClient.GetStreamingResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this image? Answer in one sentence."),
                    new UriContent(new Uri(TestImageUrl), "image/png"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            }))
        {
            updateCount++;
            if (update.Text is not null)
            {
                allText.Append(update.Text);
            }
        }

        Console.WriteLine($"Received {updateCount} chunks");
        Console.WriteLine($"Full text: {allText}");

        updateCount.Should().BeGreaterThan(1, "streaming should produce multiple chunks");
        allText.Length.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task ChatClient_DataContent_Image()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        // Download image and send as inline DataContent (base64)
        using var httpClient = new HttpClient();
        var imageBytes = await httpClient.GetByteArrayAsync(TestImageUrl);

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What do you see in this image? Answer in one sentence."),
                    new DataContent(imageBytes, "image/png"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 128,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ChatClient_DataContent_Audio()
    {
        using var api = GetAuthenticatedClient();
        MeaiChatClient chatClient = api;

        // Download audio and send as inline DataContent (base64)
        using var httpClient = new HttpClient();
        var audioBytes = await httpClient.GetByteArrayAsync(TestAudioUrl);

        var response = await chatClient.GetResponseAsync(
            [
                new ChatMessage(ChatRole.User,
                [
                    new TextContent("What language is spoken in this audio? Answer in one word."),
                    new DataContent(audioBytes, "audio/wav"),
                ]),
            ],
            new ChatOptions
            {
                ModelId = "reka-flash",
                MaxOutputTokens = 64,
            });

        Console.WriteLine($"Response: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
    }
}
