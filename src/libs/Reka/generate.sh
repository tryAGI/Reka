#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Reka \
  --clientClassName RekaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
