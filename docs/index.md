# Reka

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.Reka)](https://www.nuget.org/packages/tryAGI.Reka/)
[![dotnet](https://github.com/tryAGI/Reka/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Reka/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Reka)](https://github.com/tryAGI/Reka/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features

- Fully generated C# SDK based on the Reka OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Microsoft.Extensions.AI integration (`IChatClient` + `ISpeechToTextClient`)

### Usage

```csharp
using Reka;

using var client = new RekaClient(apiKey);

var response = await client.Chat.CreateChatCompletionAsync(
    model: "reka-flash",
    messages:
    [
        new ChatMessageInput
        {
            Role = ChatMessageInputRole.User,
            Content = "Hello!",
        }
    ]);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Reka/issues
Priority place for ideas and general questions: https://github.com/tryAGI/Reka/discussions
Discord: https://discord.gg/Ca2xhfBf3v
