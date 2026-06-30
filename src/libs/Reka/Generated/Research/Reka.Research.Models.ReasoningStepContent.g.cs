
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The result from the execution of the tool call, if applicable.
    /// </summary>
    public sealed partial class ReasoningStepContent
    {
        /// <summary>
        /// The name of the tool executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ReasoningStepContentToolNameJsonConverter))]
        public global::Reka.Research.ReasoningStepContentToolName? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output")]
        public global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepContentToolOutputItems>? ToolOutput { get; set; }

        /// <summary>
        /// The error message from the tool execution, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_error")]
        public string? ToolError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContent" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool executed.
        /// </param>
        /// <param name="toolOutput"></param>
        /// <param name="toolError">
        /// The error message from the tool execution, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepContent(
            global::Reka.Research.ReasoningStepContentToolName? toolName,
            global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepContentToolOutputItems>? toolOutput,
            string? toolError)
        {
            this.ToolName = toolName;
            this.ToolOutput = toolOutput;
            this.ToolError = toolError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContent" /> class.
        /// </summary>
        public ReasoningStepContent()
        {
        }

    }
}