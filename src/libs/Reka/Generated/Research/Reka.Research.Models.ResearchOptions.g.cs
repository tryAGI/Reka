
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchOptions
    {
        /// <summary>
        /// Configuration for web search capabilities. This allows the agent to perform web searches to gather information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search")]
        public global::Reka.Research.ResearchOptionsWebSearch? WebSearch { get; set; }

        /// <summary>
        /// Configuration for Test Time Compute (Parallel Thinking). Use this to trade added compute for higher quality responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_thinking")]
        public global::Reka.Research.ResearchOptionsParallelThinking? ParallelThinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptions" /> class.
        /// </summary>
        /// <param name="webSearch">
        /// Configuration for web search capabilities. This allows the agent to perform web searches to gather information.
        /// </param>
        /// <param name="parallelThinking">
        /// Configuration for Test Time Compute (Parallel Thinking). Use this to trade added compute for higher quality responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOptions(
            global::Reka.Research.ResearchOptionsWebSearch? webSearch,
            global::Reka.Research.ResearchOptionsParallelThinking? parallelThinking)
        {
            this.WebSearch = webSearch;
            this.ParallelThinking = parallelThinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptions" /> class.
        /// </summary>
        public ResearchOptions()
        {
        }

    }
}