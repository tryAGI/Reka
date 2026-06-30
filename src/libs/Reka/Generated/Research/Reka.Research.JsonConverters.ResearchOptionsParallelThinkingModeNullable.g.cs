#nullable enable

namespace Reka.Research.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchOptionsParallelThinkingModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Research.ResearchOptionsParallelThinkingMode?>
    {
        /// <inheritdoc />
        public override global::Reka.Research.ResearchOptionsParallelThinkingMode? Read(
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
                        return global::Reka.Research.ResearchOptionsParallelThinkingModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Research.ResearchOptionsParallelThinkingMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Research.ResearchOptionsParallelThinkingMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Research.ResearchOptionsParallelThinkingMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Reka.Research.ResearchOptionsParallelThinkingModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
