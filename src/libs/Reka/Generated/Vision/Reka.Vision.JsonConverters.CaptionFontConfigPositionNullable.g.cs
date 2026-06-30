#nullable enable

namespace Reka.Vision.JsonConverters
{
    /// <inheritdoc />
    public sealed class CaptionFontConfigPositionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Vision.CaptionFontConfigPosition?>
    {
        /// <inheritdoc />
        public override global::Reka.Vision.CaptionFontConfigPosition? Read(
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
                        return global::Reka.Vision.CaptionFontConfigPositionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Vision.CaptionFontConfigPosition)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Vision.CaptionFontConfigPosition?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Vision.CaptionFontConfigPosition? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reka.Vision.CaptionFontConfigPositionExtensions.ToValueString(value.Value));
            }
        }
    }
}
