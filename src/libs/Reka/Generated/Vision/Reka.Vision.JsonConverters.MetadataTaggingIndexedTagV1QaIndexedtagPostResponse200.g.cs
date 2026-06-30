#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Reka.Vision.JsonConverters
{
    /// <inheritdoc />
    public class MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200>
    {
        /// <inheritdoc />
        public override global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("AdultContent")) __score0++;
            if (__jsonProps.Contains("Alcohol")) __score0++;
            if (__jsonProps.Contains("Description")) __score0++;
            if (__jsonProps.Contains("Drugs")) __score0++;
            if (__jsonProps.Contains("ExpectedCTR")) __score0++;
            if (__jsonProps.Contains("Gambling")) __score0++;
            if (__jsonProps.Contains("Keyword")) __score0++;
            if (__jsonProps.Contains("MoodTone")) __score0++;
            if (__jsonProps.Contains("Political")) __score0++;
            if (__jsonProps.Contains("Profanity")) __score0++;
            if (__jsonProps.Contains("Violence")) __score0++;
            if (__jsonProps.Contains("ViralityScore")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Reka.Vision.VideoTaggingAdvertisingResult? videoTaggingAdvertisingResult = default;
            string? metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Vision.VideoTaggingAdvertisingResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Vision.VideoTaggingAdvertisingResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Vision.VideoTaggingAdvertisingResult).Name}");
                        videoTaggingAdvertisingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (videoTaggingAdvertisingResult == null && metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Vision.VideoTaggingAdvertisingResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Vision.VideoTaggingAdvertisingResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Vision.VideoTaggingAdvertisingResult).Name}");
                    videoTaggingAdvertisingResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (videoTaggingAdvertisingResult == null && metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(
                videoTaggingAdvertisingResult,

                metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideoTaggingAdvertisingResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Vision.VideoTaggingAdvertisingResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Vision.VideoTaggingAdvertisingResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Vision.VideoTaggingAdvertisingResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoTaggingAdvertisingResult!, typeInfo);
            }
            else if (value.IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2!, typeInfo);
            }
        }
    }
}