#nullable enable

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionResponseMessageAnnotationsItemsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType?>
    {
        /// <inheritdoc />
        public override global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
