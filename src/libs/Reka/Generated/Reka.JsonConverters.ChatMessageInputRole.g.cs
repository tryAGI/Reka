#nullable enable

namespace Reka.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatMessageInputRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.ChatMessageInputRole>
    {
        /// <inheritdoc />
        public override global::Reka.ChatMessageInputRole Read(
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
                        return global::Reka.ChatMessageInputRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.ChatMessageInputRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.ChatMessageInputRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.ChatMessageInputRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reka.ChatMessageInputRoleExtensions.ToValueString(value));
        }
    }
}
