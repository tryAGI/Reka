# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK originally based on the Ollama OpenAPI specification, generated using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator) (the predecessor to AutoSDK). This repository uses a **source-generator-based approach** rather than the CLI-based AutoSDK pipeline used by newer tryAGI SDKs. The code is generated at build time from the OpenAPI spec via a Roslyn source generator.

**Note:** This repo does not follow the standard AutoSDK pattern. It uses the older `OpenApiGenerator` NuGet package as a build-time source generator.

## Build Commands

```bash
# Build the solution
dotnet build Reka.sln

# Build for release (also produces NuGet package)
dotnet build Reka.sln -c Release

# Run integration tests (uses Testcontainers, no API key required -- runs Ollama in Docker)
dotnet test src/tests/Reka.IntegrationTests/Reka.IntegrationTests.csproj
```

## Architecture

### Code Generation

Unlike newer tryAGI SDKs, there is **no `generate.sh` script** and **no `Generated/` directory**. Code is generated at build time by the `OpenApiGenerator` Roslyn source generator, which reads from `docs/openapi.yaml`.

- `docs/openapi.yaml` -- the OpenAPI spec consumed at build time
- The `OpenApiGenerator` NuGet package (v0.7.1) generates client code as a source generator during compilation
- Hand-written file: `src/libs/Reka/SourceGenerationContext.cs` -- JSON serializer context for trimming/AOT support

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Reka/` | Main SDK library (`OllamaApiClient`), namespace `Ollama` |
| `src/libs/Reka.Models/` | Separate models library, namespace `Ollama` |
| `src/tests/Reka.IntegrationTests/` | Integration tests using Testcontainers (Docker-based) |

### Build Configuration

- **Targets:** `netstandard2.0;net4.6.2;net6.0;net8.0` (multi-target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Fixed version (`1.1.2`) set in `src/libs/Directory.Build.props` (no MinVer)
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions + Moq + Testcontainers

### Key Differences from Standard tryAGI SDKs

- Uses `OpenApiGenerator` source generator instead of `AutoSDK` CLI
- Multi-target framework (netstandard2.0 through net8.0) instead of net10.0 only
- No `src/helpers/` directory (no FixOpenApiSpec, GenerateDocs, or TrimmingHelper)
- Tests use Docker via Testcontainers rather than API key-based integration
- Namespace is `Ollama`, not `Reka`
- Fixed version in Directory.Build.props instead of MinVer-based versioning
