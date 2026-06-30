
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The result of analyzing a webpage, containing the URL and analysis  from the "analyze" tool.
    /// </summary>
    public sealed partial class ReasoningStepContentToolOutputItems1
    {
        /// <summary>
        /// The URL of the webpage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The analysis of the webpage content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        public string? Analysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContentToolOutputItems1" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the webpage.
        /// </param>
        /// <param name="analysis">
        /// The analysis of the webpage content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepContentToolOutputItems1(
            string? url,
            string? analysis)
        {
            this.Url = url;
            this.Analysis = analysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContentToolOutputItems1" /> class.
        /// </summary>
        public ReasoningStepContentToolOutputItems1()
        {
        }

    }
}