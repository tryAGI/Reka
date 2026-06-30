
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequest
    {
        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionRequestMessagesItems> Messages { get; set; }

        /// <summary>
        /// The model name used to generate the response.<br/>
        /// Currently, only `"reka-flash-research"` is supported for this endpoint.<br/>
        /// Default Value: reka-flash-research
        /// </summary>
        /// <default>"reka-flash-research"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "reka-flash-research";

        /// <summary>
        /// Determines whether to stream the response incrementally.<br/>
        /// If set to `true`, the agent will return a stream of response chunks. If `false`, the response will be returned as a single object.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("research")]
        public global::Reka.Research.ResearchOptions? Research { get; set; }

        /// <summary>
        /// An object specifying the format that the agent must output.<br/>
        /// Setting this to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs, which ensures the agent returns output that matches the supplied JSON schema.<br/>
        /// If not specified, the agent will return a plain text response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Reka.Research.ResponseFormatJsonSchema? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// The model name used to generate the response.<br/>
        /// Currently, only `"reka-flash-research"` is supported for this endpoint.<br/>
        /// Default Value: reka-flash-research
        /// </param>
        /// <param name="stream">
        /// Determines whether to stream the response incrementally.<br/>
        /// If set to `true`, the agent will return a stream of response chunks. If `false`, the response will be returned as a single object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="research"></param>
        /// <param name="responseFormat">
        /// An object specifying the format that the agent must output.<br/>
        /// Setting this to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs, which ensures the agent returns output that matches the supplied JSON schema.<br/>
        /// If not specified, the agent will return a plain text response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionRequestMessagesItems> messages,
            string model,
            bool? stream,
            global::Reka.Research.ResearchOptions? research,
            global::Reka.Research.ResponseFormatJsonSchema? responseFormat)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Stream = stream;
            this.Research = research;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequest" /> class.
        /// </summary>
        public CreateChatCompletionRequest()
        {
        }

    }
}