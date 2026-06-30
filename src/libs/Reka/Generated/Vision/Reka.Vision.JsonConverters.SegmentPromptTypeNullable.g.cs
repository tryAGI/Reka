#nullable enable

namespace Reka.Vision.JsonConverters
{
    /// <inheritdoc />
    public sealed class SegmentPromptTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Vision.SegmentPromptType?>
    {
        /// <inheritdoc />
        public override global::Reka.Vision.SegmentPromptType? Read(
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
                        return global::Reka.Vision.SegmentPromptTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Vision.SegmentPromptType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Vision.SegmentPromptType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Vision.SegmentPromptType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reka.Vision.SegmentPromptTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
