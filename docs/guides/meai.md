# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Reka SDK implements `IChatClient` and `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), providing unified interfaces for chat completions and speech-to-text transcription.

!!! warning "Namespace Conflict"
    Reka has a generated `IChatClient` interface that shadows `Microsoft.Extensions.AI.IChatClient`. Use full qualification or a type alias when both namespaces are in scope:
    ```csharp
    using Meai = Microsoft.Extensions.AI;
    Meai.IChatClient client = new RekaClient(...);
    ```

## Installation

```bash
dotnet add package tryAGI.Reka
```

## Chat Completions

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.IChatClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

var response = await client.GetResponseAsync(
    "What is the capital of France?",
    new Meai.ChatOptions { ModelId = "reka-flash" });

Console.WriteLine(response.Text);
```

## Streaming

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.IChatClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

await foreach (var update in client.GetStreamingResponseAsync(
    "Explain quantum computing in simple terms.",
    new Meai.ChatOptions { ModelId = "reka-flash" }))
{
    Console.Write(update.Text);
}
```

## Tool Calling

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.IChatClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

var tool = Meai.AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is sunny, 22C.",
    "GetWeather",
    "Gets the current weather for a given location.");

var options = new Meai.ChatOptions
{
    ModelId = "reka-flash",
    Tools = [tool],
};

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What is the weather in London?"),
};

var response = await client.GetResponseAsync(messages, options);
messages.AddRange(response.ToChatMessages());

if (response.FinishReason == Meai.ChatFinishReason.ToolCalls)
{
    var results = await response.CallToolsAsync(options);
    messages.AddRange(results);

    // Reka recommends omitting tools on follow-up requests
    var followUp = new Meai.ChatOptions { ModelId = "reka-flash" };
    response = await client.GetResponseAsync(messages, followUp);
}

Console.WriteLine(response.Text);
```

## Multimodal Content (Images, Audio, Video, PDFs)

Reka supports multimodal inputs via URL references:

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.IChatClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User,
    [
        new Meai.TextContent("Describe this image."),
        new Meai.UriContent(
            new Uri("https://example.com/photo.jpg"), "image/jpeg"),
    ]),
};

var response = await client.GetResponseAsync(
    messages,
    new Meai.ChatOptions { ModelId = "reka-flash" });

Console.WriteLine(response.Text);
```

## Structured JSON Output

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.IChatClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

var options = new Meai.ChatOptions
{
    ModelId = "reka-flash",
    ResponseFormat = Meai.ChatResponseFormatJson.Default,
};

var response = await client.GetResponseAsync(
    "List the top 3 programming languages as JSON with name and year fields.",
    options);

Console.WriteLine(response.Text);
```

## Speech-to-Text

`RekaClient` also implements `ISpeechToTextClient` for audio transcription:

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

Meai.ISpeechToTextClient client = new RekaClient(
    apiKey: Environment.GetEnvironmentVariable("REKA_API_KEY")!);

await using var audioStream = File.OpenRead("recording.wav");
var response = await client.GetTextAsync(audioStream);

Console.WriteLine($"Transcript: {response.Text}");
Console.WriteLine($"Start: {response.StartTime}");
Console.WriteLine($"End: {response.EndTime}");
```

## Dependency Injection

```csharp
using Meai = Microsoft.Extensions.AI;
using Reka;

var builder = WebApplication.CreateBuilder(args);

var rekaClient = new RekaClient(apiKey: builder.Configuration["Reka:ApiKey"]!);
builder.Services.AddSingleton<Meai.IChatClient>(rekaClient);
builder.Services.AddSingleton<Meai.ISpeechToTextClient>(rekaClient);
```
