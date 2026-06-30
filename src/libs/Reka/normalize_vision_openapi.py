#!/usr/bin/env python3
"""Normalize Reka's Fern-generated Vision OpenAPI spec for SDK generation."""

from __future__ import annotations

import sys
from pathlib import Path

import yaml

TAG_NAMES = {
    "subpackage_clipApi": "Clips",
    "subpackage_images": "Images",
    "subpackage_inference": "Inference",
    "subpackage_metadataTagging": "MetadataTagging",
    "subpackage_v2": "V2",
    "subpackage_videoGroup": "VideoGroups",
    "subpackage_videoQa": "VideoQa",
    "subpackage_videos": "Videos",
    "subpackage_videoSearch": "VideoSearch",
}


def multipart_properties(spec: dict, path: str, method: str) -> dict:
    return spec["paths"][path][method]["requestBody"]["content"]["multipart/form-data"]["schema"]["properties"]


def main() -> int:
    if len(sys.argv) != 3:
        print("Usage: normalize_vision_openapi.py <input.yaml> <output.yaml>", file=sys.stderr)
        return 2

    input_path = Path(sys.argv[1])
    output_path = Path(sys.argv[2])
    spec = yaml.safe_load(input_path.read_text(encoding="utf-8"))

    for methods in spec.get("paths", {}).values():
        for operation in methods.values():
            if not isinstance(operation, dict):
                continue

            # The generated Fern spec models auth headers as explicit parameters.
            # AutoSDK's --security-scheme handles X-Api-Key; the rare metering
            # override can still be supplied through AutoSDKRequestOptions.Headers.
            operation["parameters"] = [
                parameter
                for parameter in operation.get("parameters", [])
                if parameter.get("name") != "X-Enable-Overwrite-Metering"
            ]
            operation["tags"] = [TAG_NAMES.get(tag, tag) for tag in operation.get("tags", [])]

    for path in ("/v1/videos/upload", "/v2/videos"):
        multipart_properties(spec, path, "post")["file"]["format"] = "binary"

    multipart_properties(spec, "/v1/images/upload", "post")["images"]["items"]["format"] = "binary"
    multipart_properties(spec, "/v1/qa/quicktag", "post")["video"]["format"] = "binary"

    output_path.write_text(yaml.safe_dump(spec, sort_keys=False), encoding="utf-8")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
