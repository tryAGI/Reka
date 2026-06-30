#nullable enable

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionResponseChoicesItemsFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason?>
    {
        /// <inheritdoc />
        public override global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason? Read(
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
                        return global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
