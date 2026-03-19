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
}
