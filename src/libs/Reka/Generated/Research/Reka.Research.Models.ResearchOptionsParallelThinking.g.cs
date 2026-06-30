
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// Configuration for Test Time Compute (Parallel Thinking). Use this to trade added compute for higher quality responses.
    /// </summary>
    public sealed partial class ResearchOptionsParallelThinking
    {
        /// <summary>
        /// The level of additional compute to use for generating the answer. Use "none" for default behavior, "low" for moderate additional compute, or "high" for maximum additional compute and quality.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ResearchOptionsParallelThinkingModeJsonConverter))]
        public global::Reka.Research.ResearchOptionsParallelThinkingMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsParallelThinking" /> class.
        /// </summary>
        /// <param name="mode">
        /// The level of additional compute to use for generating the answer. Use "none" for default behavior, "low" for moderate additional compute, or "high" for maximum additional compute and quality.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOptionsParallelThinking(
            global::Reka.Research.ResearchOptionsParallelThinkingMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsParallelThinking" /> class.
        /// </summary>
        public ResearchOptionsParallelThinking()
        {
        }

    }
}