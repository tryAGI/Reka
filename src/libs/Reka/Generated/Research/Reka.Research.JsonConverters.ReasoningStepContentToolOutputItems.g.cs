#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public class ReasoningStepContentToolOutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.ReasoningStepContentToolOutputItems>
    {
        /// <inheritdoc />
        public override global::Reka.Research.ReasoningStepContentToolOutputItems Read(
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
            if (__jsonProps.Contains("age")) __score0++;
            if (__jsonProps.Contains("snippet")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("analysis")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Reka.Research.ReasoningStepContentToolOutputItems0? reasoningStepContentToolOutputItems0 = default;
            global::Reka.Research.ReasoningStepContentToolOutputItems1? reasoningStepContentToolOutputItems1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0).Name}");
                        reasoningStepContentToolOutputItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1).Name}");
                        reasoningStepContentToolOutputItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reasoningStepContentToolOutputItems0 == null && reasoningStepContentToolOutputItems1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0).Name}");
                    reasoningStepContentToolOutputItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningStepContentToolOutputItems0 == null && reasoningStepContentToolOutputItems1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1).Name}");
                    reasoningStepContentToolOutputItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Reka.Research.ReasoningStepContentToolOutputItems(
                reasoningStepContentToolOutputItems0,

                reasoningStepContentToolOutputItems1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.ReasoningStepContentToolOutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningStepContentToolOutputItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningStepContentToolOutputItems0!, typeInfo);
            }
            else if (value.IsReasoningStepContentToolOutputItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.ReasoningStepContentToolOutputItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningStepContentToolOutputItems1!, typeInfo);
            }
        }
    }
}