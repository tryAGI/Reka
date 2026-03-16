using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Ollama.IntegrationTests;

public partial class Tests
{
    private static async Task<TestEnvironment> PrepareEnvironmentAsync(TestEnvironmentType environmentType, string model = "")
    {
        switch (environmentType)
        {
            case TestEnvironmentType.Local:
                return await CreateEnvironmentAsync(
                    new OllamaApiClient(baseUri: CreateLocalBaseUri()),
                    model).ConfigureAwait(false);
            case TestEnvironmentType.Container:
            {
                const int ollamaPort = 11434;

                var container = new ContainerBuilder()
                    .WithImage("ollama/ollama")
                    .WithPortBinding(ollamaPort, true)
                    .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(ollamaPort))
                    .Build();

                await container.StartAsync().ConfigureAwait(false);

                return await CreateEnvironmentAsync(
                    new OllamaApiClient(
                        baseUri: new Uri($"http://{container.Hostname}:{container.GetMappedPublicPort(ollamaPort)}/api")),
                    model,
                    container).ConfigureAwait(false);
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static Uri CreateLocalBaseUri()
    {
        var ollamaHost = System.Environment.GetEnvironmentVariable("OLLAMA_HOST");
        if (string.IsNullOrWhiteSpace(ollamaHost))
        {
            return new Uri("http://localhost:11434/api");
        }

        if (!ollamaHost.Contains("://", StringComparison.Ordinal))
        {
            ollamaHost = $"http://{ollamaHost}";
        }

        if (!ollamaHost.EndsWith("/api", StringComparison.OrdinalIgnoreCase))
        {
            ollamaHost = $"{ollamaHost.TrimEnd('/')}/api";
        }

        return new Uri(ollamaHost, UriKind.Absolute);
    }

    private static async Task<TestEnvironment> CreateEnvironmentAsync(
        OllamaApiClient apiClient,
        string model,
        IContainer? container = null)
    {
        if (!string.IsNullOrEmpty(model))
        {
            await PullModelAndEnsureSuccessAsync(apiClient, model).ConfigureAwait(false);
        }

        return new TestEnvironment(apiClient, container);
    }

    private static async Task PullModelAndEnsureSuccessAsync(OllamaApiClient apiClient, string model)
    {
        var response = await ReadLastAsync(
            apiClient.PullModelAsync(model, stream: false)).ConfigureAwait(false);

        response.Status.Should().Be(PullModelResponseStatus.Success);
    }

    private static async Task<T> ReadLastAsync<T>(IAsyncEnumerable<T> source)
    {
        var hasValue = false;
        var last = default(T);

        await foreach (var item in source.ConfigureAwait(false))
        {
            last = item;
            hasValue = true;
        }

        if (!hasValue)
        {
            throw new InvalidOperationException("The operation did not return any results.");
        }

        return last!;
    }

    [TestMethod]
    public async Task ListModels()
    {
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container);

        var models = await container.ApiClient.ListModelsAsync();
        models.Models.Should().BeNullOrEmpty();

        await PullModelAndEnsureSuccessAsync(container.ApiClient, "all-minilm");

        models = await container.ApiClient.ListModelsAsync();
        models.Models.Should().NotBeNull();
        models.Models.Should().HaveCount(1);
        models.Models![0].Model.Should().Be("all-minilm:latest");
    }

    [TestMethod]
    public async Task PullModel()
    {
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container);

        await foreach (var response in container.ApiClient.PullModelAsync("all-minilm", stream: true))
        {
            Console.WriteLine($"{response.Status}. Progress: {response.Completed}/{response.Total}");
        }

        var response2 = await ReadLastAsync(container.ApiClient.PullModelAsync("all-minilm", stream: false));
        response2.Status.Should().Be(PullModelResponseStatus.Success);

        await PullModelAndEnsureSuccessAsync(container.ApiClient, "all-minilm");
    }

    [TestMethod]
    public async Task Embeddings()
    {
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container);

        await PullModelAndEnsureSuccessAsync(container.ApiClient, "all-minilm");

        var embeddingResponse = await container.ApiClient.GenerateEmbeddingAsync(
            model: "all-minilm",
            prompt: "hello");

        embeddingResponse.Embedding.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task GetCompletionWithOptions()
    {
#if DEBUG
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Local, "llama3");
#else
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container, "llama3");
#endif

        var response = await ReadLastAsync(container.ApiClient.GenerateCompletionAsync(new GenerateCompletionRequest
        {
            Model = "llama3",
            Prompt = "answer me just \"123\"",
            Stream = false,
            Options = new RequestOptions
            {
                Temperature = 0,
            },
        }));
        Console.WriteLine(response.Response);
    }

    [TestMethod]
    public async Task GetCompletion()
    {
#if DEBUG
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Local, "llama3");
#else
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container, "llama3");
#endif

        IList<long>? context = null;
        var enumerable = container.ApiClient.GenerateCompletionAsync("llama3", "answer 5 random words", stream: true);
        await foreach (var response in enumerable)
        {
            Console.WriteLine($"> {response.Response}");

            context = response.Context;
        }

        var lastResponse = await ReadLastAsync(
            container.ApiClient.GenerateCompletionAsync("llama3", "answer 123", stream: false, context: context));
        Console.WriteLine(lastResponse.Response);
    }

    [TestMethod]
    public async Task GetChat()
    {
#if DEBUG
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Local, "llama3");
#else
        await using var container = await PrepareEnvironmentAsync(TestEnvironmentType.Container, "llama3");
#endif

        var response = await ReadLastAsync(container.ApiClient.GenerateChatCompletionAsync(
            model: "llama3",
            messages:
            [
                new Message
                {
                    Role = MessageRole.User,
                    Content = "answer in 5 words",
                },
            ],
            stream: false));

        Console.WriteLine(response.Message?.Content);
    }
}

internal enum TestEnvironmentType
{
    Local,
    Container,
}

internal sealed class TestEnvironment : IAsyncDisposable
{
    internal TestEnvironment(OllamaApiClient apiClient, IContainer? container = null)
    {
        ApiClient = apiClient;
        Container = container;
    }

    internal OllamaApiClient ApiClient { get; }

    internal IContainer? Container { get; }

    public async ValueTask DisposeAsync()
    {
        ApiClient.Dispose();

        if (Container is not null)
        {
            await Container.DisposeAsync().ConfigureAwait(false);
        }
    }
}
