#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public class CreateChatCompletionResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.CreateChatCompletionResponse200>
    {
        /// <inheritdoc />
        public override global::Reka.Research.CreateChatCompletionResponse200 Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("choices")) __score0++;
            if (__jsonProps.Contains("created")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("usage")) __score0++;
            if (__jsonProps.Contains("usage.completion_tokens")) __score0++;
            if (__jsonProps.Contains("usage.prompt_tokens")) __score0++;
            if (__jsonProps.Contains("usage.total_tokens")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("choices")) __score1++;
            if (__jsonProps.Contains("created")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("object")) __score1++;
            if (__jsonProps.Contains("usage")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Reka.Research.CreateChatCompletionResponse? createChatCompletionResponse = default;
            global::Reka.Research.CreateChatCompletionStreamResponse? createChatCompletionStreamResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionResponse).Name}");
                        createChatCompletionResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionStreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionStreamResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionStreamResponse).Name}");
                        createChatCompletionStreamResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createChatCompletionResponse == null && createChatCompletionStreamResponse == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionResponse).Name}");
                    createChatCompletionResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createChatCompletionResponse == null && createChatCompletionStreamResponse == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionStreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionStreamResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionStreamResponse).Name}");
                    createChatCompletionStreamResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Reka.Research.CreateChatCompletionResponse200(
                createChatCompletionResponse,

                createChatCompletionStreamResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.CreateChatCompletionResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateChatCompletionResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatCompletionResponse!, typeInfo);
            }
            else if (value.IsCreateChatCompletionStreamResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionStreamResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionStreamResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionStreamResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatCompletionStreamResponse!, typeInfo);
            }
        }
    }
}