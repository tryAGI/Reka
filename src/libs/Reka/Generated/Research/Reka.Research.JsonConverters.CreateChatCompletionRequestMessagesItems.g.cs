#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public class CreateChatCompletionRequestMessagesItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.CreateChatCompletionRequestMessagesItems>
    {
        /// <inheritdoc />
        public override global::Reka.Research.CreateChatCompletionRequestMessagesItems Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Reka.Research.CreateChatCompletionRequestMessagesItems0? createChatCompletionRequestMessagesItems0 = default;
            global::Reka.Research.CreateChatCompletionRequestMessagesItems1? createChatCompletionRequestMessagesItems1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0).Name}");
                        createChatCompletionRequestMessagesItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1).Name}");
                        createChatCompletionRequestMessagesItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createChatCompletionRequestMessagesItems0 == null && createChatCompletionRequestMessagesItems1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0).Name}");
                    createChatCompletionRequestMessagesItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (createChatCompletionRequestMessagesItems0 == null && createChatCompletionRequestMessagesItems1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1).Name}");
                    createChatCompletionRequestMessagesItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Reka.Research.CreateChatCompletionRequestMessagesItems(
                createChatCompletionRequestMessagesItems0,

                createChatCompletionRequestMessagesItems1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.CreateChatCompletionRequestMessagesItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateChatCompletionRequestMessagesItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatCompletionRequestMessagesItems0!, typeInfo);
            }
            else if (value.IsCreateChatCompletionRequestMessagesItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Reka.Research.CreateChatCompletionRequestMessagesItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateChatCompletionRequestMessagesItems1!, typeInfo);
            }
        }
    }
}