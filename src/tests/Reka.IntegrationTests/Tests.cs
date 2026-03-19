using System.Text;
using System.Text.Json;

namespace Reka.IntegrationTests;

[TestClass]
public partial class Tests
{
    private const string TestAudioUrl =
        "https://github.com/AssemblyAI-Community/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3";

    private const string TestImageUrl =
        "https://picsum.photos/200";

    private const string TestPdfUrl =
        "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf";

    private const string TestVideoUrl =
        "https://storage.googleapis.com/gtv-videos-bucket/sample/ForBiggerMeltdowns.mp4";

    public RekaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REKA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("REKA_API_KEY environment variable is not found.");

        var api = new RekaClient(apiKey);

        return api;
    }

    private (RekaClient client, CaptureHandler capture) CreateCapturingClient()
    {
        var capture = new CaptureHandler();
        var httpClient = new HttpClient(capture)
        {
            BaseAddress = new Uri("https://api.reka.ai"),
        };
        var client = new RekaClient(httpClient: httpClient, disposeHttpClient: true);

        return (client, capture);
    }

    internal sealed class CaptureHandler : HttpMessageHandler
    {
        public JsonDocument? LastRequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Content is not null)
            {
                var body = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                LastRequestBody = JsonDocument.Parse(body);
            }

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json"),
            };
        }
    }
}
