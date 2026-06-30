
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// A single reasoning step.
    /// </summary>
    public sealed partial class ReasoningStep
    {
        /// <summary>
        /// The author of the reasoning step.<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Reka.Research.ReasoningStepRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ReasoningStepRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Research.ReasoningStepRole Role { get; set; } = global::Reka.Research.ReasoningStepRole.Assistant;

        /// <summary>
        /// The agent's internal reasoning — a natural language explanation of its intent before acting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// A list of tool calls made by the agent during this reasoning step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepToolCallsItems>? ToolCalls { get; set; }

        /// <summary>
        /// The result from the execution of the tool call, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.OneOfJsonConverter<global::Reka.Research.ReasoningStepContent, object>))]
        public global::Reka.Research.OneOf<global::Reka.Research.ReasoningStepContent, object>? Content { get; set; }

        /// <summary>
        /// The unique identifier of the tool call that produced this reasoning step. This is used to link the reasoning step to the tool call in an earlier reasoning step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStep" /> class.
        /// </summary>
        /// <param name="role">
        /// The author of the reasoning step.<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="reasoningContent">
        /// The agent's internal reasoning — a natural language explanation of its intent before acting.
        /// </param>
        /// <param name="toolCalls">
        /// A list of tool calls made by the agent during this reasoning step.
        /// </param>
        /// <param name="content">
        /// The result from the execution of the tool call, if applicable.
        /// </param>
        /// <param name="toolCallId">
        /// The unique identifier of the tool call that produced this reasoning step. This is used to link the reasoning step to the tool call in an earlier reasoning step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStep(
            global::Reka.Research.ReasoningStepRole role,
            string? reasoningContent,
            global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepToolCallsItems>? toolCalls,
            global::Reka.Research.OneOf<global::Reka.Research.ReasoningStepContent, object>? content,
            string? toolCallId)
        {
            this.Role = role;
            this.ReasoningContent = reasoningContent;
            this.ToolCalls = toolCalls;
            this.Content = content;
            this.ToolCallId = toolCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStep" /> class.
        /// </summary>
        public ReasoningStep()
        {
        }

    }
}