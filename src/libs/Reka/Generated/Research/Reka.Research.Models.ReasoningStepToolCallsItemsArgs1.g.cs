
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The arguments for the `search_web` tool call, which includes the query and optional filters.
    /// </summary>
    public sealed partial class ReasoningStepToolCallsItemsArgs1
    {
        /// <summary>
        /// The search query to execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItemsArgs1" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query to execute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepToolCallsItemsArgs1(
            string query)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItemsArgs1" /> class.
        /// </summary>
        public ReasoningStepToolCallsItemsArgs1()
        {
        }

    }
}