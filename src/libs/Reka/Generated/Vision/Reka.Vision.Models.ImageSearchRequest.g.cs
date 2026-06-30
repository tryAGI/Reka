
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSearchRequest
    {
        /// <summary>
        /// Search query text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Search mode: 'vision' for vision-only search, 'joined' for hybrid search<br/>
        /// Default Value: vision
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.ImageSearchRequestSearchModeJsonConverter))]
        public global::Reka.Vision.ImageSearchRequestSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Weight of the image in the search (only used when search_mode='joined')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_weight")]
        public double? ImageWeight { get; set; }

        /// <summary>
        /// Weight of the text in the search (only used when search_mode='joined')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_weight")]
        public double? TextWeight { get; set; }

        /// <summary>
        /// Similarity score threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="maxResults">
        /// Default Value: 10
        /// </param>
        /// <param name="searchMode">
        /// Search mode: 'vision' for vision-only search, 'joined' for hybrid search<br/>
        /// Default Value: vision
        /// </param>
        /// <param name="imageWeight">
        /// Weight of the image in the search (only used when search_mode='joined')
        /// </param>
        /// <param name="textWeight">
        /// Weight of the text in the search (only used when search_mode='joined')
        /// </param>
        /// <param name="threshold">
        /// Similarity score threshold
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSearchRequest(
            string query,
            int? maxResults,
            global::Reka.Vision.ImageSearchRequestSearchMode? searchMode,
            double? imageWeight,
            double? textWeight,
            double? threshold)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.MaxResults = maxResults;
            this.SearchMode = searchMode;
            this.ImageWeight = imageWeight;
            this.TextWeight = textWeight;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchRequest" /> class.
        /// </summary>
        public ImageSearchRequest()
        {
        }

    }
}