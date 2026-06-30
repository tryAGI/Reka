#nullable enable

namespace Reka.Vision.JsonConverters
{
    /// <inheritdoc />
    public sealed class V2InferenceRequestsGetParametersStatusSchemaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema>
    {
        /// <inheritdoc />
        public override global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema Read(
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
                        return global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchemaExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchemaExtensions.ToValueString(value));
        }
    }
}
