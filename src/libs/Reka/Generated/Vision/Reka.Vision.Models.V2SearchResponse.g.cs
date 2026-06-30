
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2SearchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.V2SearchResult> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// LLM-generated summary (when include_report=true, semantic only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report")]
        public string? Report { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_pool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.SearchPool SearchPool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="searchPool"></param>
        /// <param name="nextPageToken"></param>
        /// <param name="report">
        /// LLM-generated summary (when include_report=true, semantic only)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2SearchResponse(
            global::System.Collections.Generic.IList<global::Reka.Vision.V2SearchResult> data,
            global::Reka.Vision.SearchPool searchPool,
            string? nextPageToken,
            string? report)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPageToken = nextPageToken;
            this.Report = report;
            this.SearchPool = searchPool ?? throw new global::System.ArgumentNullException(nameof(searchPool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchResponse" /> class.
        /// </summary>
        public V2SearchResponse()
        {
        }

    }
}