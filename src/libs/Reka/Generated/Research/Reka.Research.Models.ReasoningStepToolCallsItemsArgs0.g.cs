
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The arguments for the `analyze` tool call, which includes the URLs to analyze and the type of analysis to perform.
    /// </summary>
    public sealed partial class ReasoningStepToolCallsItemsArgs0
    {
        /// <summary>
        /// The list of URLs to analyze.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Urls { get; set; }

        /// <summary>
        /// The type of analysis to perform on the webpage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItemsArgs0" /> class.
        /// </summary>
        /// <param name="urls">
        /// The list of URLs to analyze.
        /// </param>
        /// <param name="task">
        /// The type of analysis to perform on the webpage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepToolCallsItemsArgs0(
            global::System.Collections.Generic.IList<object> urls,
            string task)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepToolCallsItemsArgs0" /> class.
        /// </summary>
        public ReasoningStepToolCallsItemsArgs0()
        {
        }

    }
}