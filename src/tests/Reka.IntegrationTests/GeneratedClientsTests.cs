using System.Net;
using System.Net.Http.Headers;
using System.Text;
using ResearchClient = Reka.Research.RekaResearchClient;
using ResearchMessage = Reka.Research.CreateChatCompletionRequestMessagesItems;
using ResearchUserMessage = Reka.Research.CreateChatCompletionRequestMessagesItems0;
using VisionClient = Reka.Vision.RekaVisionClient;

namespace Reka.IntegrationTests;

[TestClass]
public sealed class GeneratedClientsTests
{
    [TestMethod]
    public async Task VisionClient_UploadVideo_UsesMultipartAndApiKeyAuth()
    {
        var capture = new RawCaptureHandler(
            """
            {
              "video_id": "550e8400-e29b-41d4-a716-446655440000",
              "status": "upload_initiated"
            }
            """);
        using var httpClient = new HttpClient(capture);
        using var api = new VisionClient("test-key", httpClient: httpClient, disposeHttpClient: true);

        var response = await api.Videos.UploadAsync(
            index: true,
            file: [0x00, 0x01, 0x02],
            filename: "clip.mp4",
            videoName: "clip.mp4");

        response.VideoId.Should().Be("550e8400-e29b-41d4-a716-446655440000");
        capture.LastMethod.Should().Be(HttpMethod.Post);
        capture.LastRequestUri.Should().Be(new Uri("https://vision-agent.api.reka.ai/v1/videos/upload"));
        capture.LastHeaders["X-Api-Key"].Should().Contain("test-key");
        capture.LastContentType.Should().StartWith("multipart/form-data");
        capture.LastContent.Should().Contain("name=\"file\"");
        capture.LastContent.Should().Contain("filename=\"clip.mp4\"");
        capture.LastContent.Should().Contain("name=\"index\"");
        capture.LastContent.Should().Contain("name=\"video_name\"");
    }

    [TestMethod]
    public async Task ResearchClient_CreateChatCompletion_UsesBearerAuth()
    {
        var capture = new RawCaptureHandler(
            """
            {
              "id": "chatcmpl-test",
              "choices": [
                {
                  "finish_reason": "stop",
                  "index": 0,
                  "message": {
                    "role": "assistant",
                    "content": "ok"
                  }
                }
              ],
              "created": 1,
              "model": "reka-flash-research"
            }
            """);
        using var httpClient = new HttpClient(capture);
        using var api = new ResearchClient("research-key", httpClient: httpClient, disposeHttpClient: true);

        await api.CreateChatCompletionAsync(new Reka.Research.CreateChatCompletionRequest
        {
            Model = "reka-flash-research",
            Messages =
            [
                ResearchMessage.FromCreateChatCompletionRequestMessagesItems0(
                    ResearchUserMessage.FromContent("Search for recent Reka updates.")),
            ],
        });

        capture.LastMethod.Should().Be(HttpMethod.Post);
        capture.LastRequestUri.Should().Be(new Uri("https://api.reka.ai/v1/chat/completions"));
        capture.LastAuthorization.Should().Be(new AuthenticationHeaderValue("Bearer", "research-key"));
        capture.LastContent.Should().Contain("\"model\":\"reka-flash-research\"");
    }

    private sealed class RawCaptureHandler(string responseJson) : HttpMessageHandler
    {
        public HttpMethod? LastMethod { get; private set; }

        public Uri? LastRequestUri { get; private set; }

        public AuthenticationHeaderValue? LastAuthorization { get; private set; }

        public Dictionary<string, string[]> LastHeaders { get; } = new(StringComparer.OrdinalIgnoreCase);

        public string? LastContentType { get; private set; }

        public string? LastContent { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastMethod = request.Method;
            LastRequestUri = request.RequestUri;
            LastAuthorization = request.Headers.Authorization;
            LastHeaders.Clear();
            foreach (var header in request.Headers)
            {
                LastHeaders[header.Key] = [.. header.Value];
            }

            if (request.Content is not null)
            {
                LastContentType = request.Content.Headers.ContentType?.ToString();
                LastContent = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(responseJson, Encoding.UTF8, "application/json"),
            };
        }
    }
}
