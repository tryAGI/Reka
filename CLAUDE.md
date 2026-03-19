# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Reka](https://reka.ai/) AI platform, auto-generated from the Reka OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Reka.slnx

# Build for release (also produces NuGet package)
dotnet build Reka.slnx -c Release

# Run integration tests (requires REKA_API_KEY env var)
dotnet test src/tests/Reka.IntegrationTests/Reka.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Reka && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Reka/Generated/`.

1. `src/libs/Reka/openapi.yaml` — the Reka OpenAPI spec (manually maintained)
2. `src/libs/Reka/generate.sh` — runs AutoSDK CLI → output to `Generated/`

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Reka/` | Main SDK library (`RekaClient`) |
| `src/tests/Reka.IntegrationTests/` | Integration tests against real Reka API |

### Documentation Generation

Tests in `src/tests/Reka.IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/Reka.IntegrationTests/Examples`
### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### MEAI Integration

`RekaClient` implements `Microsoft.Extensions.AI.IChatClient`:
- `GetResponseAsync()` — non-streaming chat completion
- `GetStreamingResponseAsync()` — true SSE streaming via hand-written HTTP/SSE parsing
- Supports text, image/audio/video/PDF content (both `UriContent` URLs and inline `DataContent` base64), tool/function calling, structured JSON output via `ChatResponseFormat`
- Maps `ChatOptions.Seed` for reproducible outputs
- Hand-written code in `src/libs/Reka/Extensions/RekaClient.ChatClient.cs`

**Tool calling limitations (Reka API):**
- Reka doesn't support `role: "tool"` messages — tool results are sent as `role: "user"` with formatted text `[Tool result for {callId}]: {result}`
- `tool_call_id` is not sent on user messages (causes Reka 500 errors)
- Follow-up requests after tool results should omit `tools` to prevent re-calling
- Streaming with tools returns an empty response (Reka API limitation)
- Streaming tool call delta accumulation is implemented but untestable until Reka adds support

`RekaClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`:
- `GetTextAsync()` — audio transcription/translation via base64 data URI conversion
- `GetStreamingTextAsync()` — delegates to non-streaming (Reka API doesn't support streaming speech)
- Hand-written code in `src/libs/Reka/Extensions/RekaClient.SpeechToTextClient.cs`

**Note:** `Reka.IChatClient` (generated) and `Microsoft.Extensions.AI.IChatClient` share the same short name. Use full qualification or type alias (`using MeaiChatClient = Microsoft.Extensions.AI.IChatClient;`) to avoid ambiguity.

### Reka Research Model

The Research model (`reka-flash-research`) uses the same `/v1/chat/completions` endpoint with additional capabilities:
- `research` parameter — configures web search and parallel thinking
- `response_format` parameter — structured JSON output via JSON Schema
- Response includes `reasoning_steps`, `reasoning_content`, and `annotations` (URL citations)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
