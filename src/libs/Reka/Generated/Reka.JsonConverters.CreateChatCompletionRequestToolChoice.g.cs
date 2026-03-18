#nullable enable

namespace Reka.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionRequestToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.CreateChatCompletionRequestToolChoice>
    {
        /// <inheritdoc />
        public override global::Reka.CreateChatCompletionRequestToolChoice Read(
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
                        return global::Reka.CreateChatCompletionRequestToolChoiceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.CreateChatCompletionRequestToolChoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.CreateChatCompletionRequestToolChoice);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.CreateChatCompletionRequestToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reka.CreateChatCompletionRequestToolChoiceExtensions.ToValueString(value));
        }
    }
}
