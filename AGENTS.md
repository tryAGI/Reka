# AGENTS.md

## Project

Reka is a .NET 10 SDK generated with AutoSDK. The package ID is `Reka`,
and the main namespace and client are `Reka` and `RekaClient`.

## Generation

- Core source: `src/libs/Reka/openapi.yaml` (locally maintained chat, models, speech).
- Official snapshots: `vision.openapi.yaml` and `research.openapi.yaml` in the same directory.
- Regenerate from `src/libs/Reka/` with `./generate.sh`.
- Never edit `Generated/` manually. Hand-written partial classes and MEAI adapters
  live outside that directory.
- Core and Research use Bearer authentication; Vision uses `X-Api-Key`.
- `Authentication.cs` preserves the previous core authorization method names.

## Validation

```bash
dotnet build Reka.slnx -c Release
dotnet test src/tests/Reka.IntegrationTests/Reka.IntegrationTests.csproj
```

Tests use MSTest and AwesomeAssertions. Provider tests require `REKA_API_KEY`
and skip when it is missing or empty. `GeneratedClientsTests` and MEAI mapping
and metadata tests run locally without credentials or Docker.

The SDK implements `IChatClient` and `ISpeechToTextClient`. It uses source-generated
JSON, signing via `src/key.snk`, MinVer, and trimming/AOT analyzers. Shared workflows
handle regeneration and publishing. Follow workspace dependency policy and commit
scoped changes directly to `main`.
