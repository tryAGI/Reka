# Reka .NET SDK

[![NuGet](https://img.shields.io/nuget/v/tryAGI.Reka.svg)](https://www.nuget.org/packages/tryAGI.Reka/)

C# SDK for the [Reka](https://reka.ai/) AI platform, auto-generated from the Reka OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK).

## Installation

```bash
dotnet add package tryAGI.Reka
```

## Usage

### Create a client

```csharp
using Reka;

var client = new RekaClient("your-api-key");
```

### Chat completion

```csharp
var response = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What is the capital of France?",
        },
    ],
    MaxTokens = 256,
});

Console.WriteLine(response.Choices[0].Message.Content);
```

### Streaming

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

await foreach (var update in chatClient.GetStreamingResponseAsync(
    [new ChatMessage(ChatRole.User, "Count from 1 to 10")],
    new ChatOptions { ModelId = "reka-flash" }))
{
    Console.Write(update.Text);
}
```

### Microsoft.Extensions.AI (IChatClient)

The SDK implements `IChatClient` for seamless integration with the .NET AI ecosystem:

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Hello!")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        MaxOutputTokens = 128,
    });

Console.WriteLine(response.Text);
```

### Tool calling

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var weatherTool = AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72F and sunny.",
    "get_weather",
    "Gets the current weather for a location");

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "What's the weather in Tokyo?")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        Tools = [weatherTool],
    });
```

### Multimodal (images, audio, video, PDF)

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var response = await chatClient.GetResponseAsync(
    [
        new ChatMessage(ChatRole.User,
        [
            new TextContent("What do you see in this image?"),
            new UriContent(new Uri("https://example.com/photo.png"), "image/png"),
        ]),
    ],
    new ChatOptions { ModelId = "reka-flash" });
```

### Structured JSON output

```csharp
using Microsoft.Extensions.AI;

IChatClient chatClient = new RekaClient("your-api-key");

var schema = System.Text.Json.JsonDocument.Parse("""
{
    "type": "object",
    "properties": {
        "name": { "type": "string" },
        "age": { "type": "integer" }
    },
    "required": ["name", "age"],
    "additionalProperties": false
}
""").RootElement;

var response = await chatClient.GetResponseAsync(
    [new ChatMessage(ChatRole.User, "Return info about Alice who is 30.")],
    new ChatOptions
    {
        ModelId = "reka-flash",
        ResponseFormat = new ChatResponseFormatJson(schema, "person", "A person object"),
    });
```

### Speech-to-text (ISpeechToTextClient)

```csharp
using Microsoft.Extensions.AI;

ISpeechToTextClient speechClient = new RekaClient("your-api-key");

await using var audioStream = File.OpenRead("recording.wav");
var response = await speechClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
```

### Speech transcription (raw API)

```csharp
var response = await client.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = "https://example.com/audio.wav",
    SamplingRate = 16000,
});

Console.WriteLine(response.Transcript);
```

### Translation

```csharp
var response = await client.Speech.TranscribeOrTranslateAsync(new TranscribeOrTranslateRequest
{
    AudioUrl = "https://example.com/audio.wav",
    SamplingRate = 16000,
    TargetLanguage = TranscribeOrTranslateRequestTargetLanguage.French,
    IsTranslate = true,
});

Console.WriteLine(response.Translation);
```

### Research model

```csharp
var response = await client.Chat.CreateChatCompletionAsync(new CreateChatCompletionRequest
{
    Model = "reka-flash-research",
    Messages =
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "What are the latest developments in quantum computing?",
        },
    ],
    Research = new ResearchConfig
    {
        WebSearch = new WebSearchConfig { Enabled = true, MaxUses = 5 },
        ParallelThinking = new ParallelThinkingConfig { Mode = ParallelThinkingConfigMode.Low },
    },
});
```

### List models

```csharp
var models = await client.Models.ListModelsAsync();

foreach (var model in models.Data)
{
    Console.WriteLine(model.Id);
}
```

## License

[MIT](LICENSE)
