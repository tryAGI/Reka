
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// A single tool call made by the agent.
    /// </summary>
    public sealed partial class ReasoningStepToolCallsItems
    {
        /// <summary>
        /// The unique identifier for the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the tool that was called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ReasoningStepToolCallsItemsNameJsonConverter))]
        public global::Reka.Research.ReasoningStepToolCallsItemsName? Name { get; set; }

        /// <summary>
        /// The arguments passed to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ReasoningStepToolCallsItemsArgsJsonConverter))]
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the tool call.
        /// </param>
        /// <param name="name">
        /// The name of the tool that was called.
        /// </param>
        /// <param name="args">
        /// The arguments passed to the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepToolCallsItems(
            string? id,
            global::Reka.Research.ReasoningStepToolCallsItemsName? name,
            global::Reka.Research.ReasoningStepToolCallsItemsArgs? args)
        {
            this.Id = id;
            this.Name = name;
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItems" /> class.
        /// </summary>
        public ReasoningStepToolCallsItems()
        {
        }

    }
}