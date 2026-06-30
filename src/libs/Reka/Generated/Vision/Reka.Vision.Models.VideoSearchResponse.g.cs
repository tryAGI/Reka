
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSearchResponse
    {
        /// <summary>
        /// List of search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.VideoChunkSearchResult> Results { get; set; }

        /// <summary>
        /// Report summarizing the search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public string? Report { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of search results
        /// </param>
        /// <param name="report">
        /// Report summarizing the search results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSearchResponse(
            global::System.Collections.Generic.IList<global::Reka.Vision.VideoChunkSearchResult> results,
            string? report)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Report = report;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchResponse" /> class.
        /// </summary>
        public VideoSearchResponse()
        {
        }

    }
}