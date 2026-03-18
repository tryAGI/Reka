#nullable enable

namespace Reka.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReasoningStepRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.ReasoningStepRole>
    {
        /// <inheritdoc />
        public override global::Reka.ReasoningStepRole Read(
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
                        return global::Reka.ReasoningStepRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.ReasoningStepRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.ReasoningStepRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.ReasoningStepRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reka.ReasoningStepRoleExtensions.ToValueString(value));
        }
    }
}
