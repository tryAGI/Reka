
#nullable enable

namespace Reka
{
    /// <summary>
    /// Structured output configuration. Forces the model to return valid JSON matching a schema.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The response format type. Currently only "json_schema" is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.JsonConverters.ResponseFormatTypeJsonConverter))]
        public global::Reka.ResponseFormatType Type { get; set; }

        /// <summary>
        /// JSON Schema configuration for structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::Reka.JsonSchemaConfig? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The response format type. Currently only "json_schema" is supported.
        /// </param>
        /// <param name="jsonSchema">
        /// JSON Schema configuration for structured output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::Reka.ResponseFormatType type,
            global::Reka.JsonSchemaConfig? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}