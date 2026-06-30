#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated

# Core spec is locally maintained for MEAI-friendly chat/speech coverage.
autosdk generate openapi.yaml \
  --namespace Reka \
  --clientClassName RekaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

tmpdir="$(mktemp -d)"
trap 'rm -rf "$tmpdir"' EXIT

python3 normalize_vision_openapi.py vision.openapi.yaml "$tmpdir/vision.openapi.yaml"

# Vision and Research specs are tracked snapshots of the official Fern docs specs.
autosdk generate "$tmpdir/vision.openapi.yaml" \
  --namespace Reka.Vision \
  --clientClassName RekaVisionClient \
  --targetFramework net10.0 \
  --output Generated/Vision \
  --exclude-deprecated-operations \
  --json-serializer-context VisionJsonSerializerContext \
  --security-scheme ApiKey:Header:X-Api-Key \
  --generate-multipart-upload-helpers

autosdk generate research.openapi.yaml \
  --namespace Reka.Research \
  --clientClassName RekaResearchClient \
  --targetFramework net10.0 \
  --output Generated/Research \
  --exclude-deprecated-operations \
  --json-serializer-context ResearchJsonSerializerContext \
  --security-scheme Http:Header:Bearer
