
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Base class for search requests
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public global::System.Collections.Generic.IList<string>? VideoIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_ids")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_demo")]
        public bool? SearchDemo { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_llm_rerank")]
        public bool? UseLlmRerank { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_embeds_rerank")]
        public bool? UseEmbedsRerank { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ocr_to_caption")]
        public bool? AddOcrToCaption { get; set; }

        /// <summary>
        /// Filter from datetime (ISO 8601 format, e.g., 2024-01-15T10:00:00Z)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime_from")]
        public string? DatetimeFrom { get; set; }

        /// <summary>
        /// Filter to datetime (ISO 8601 format, e.g., 2024-01-15T18:00:00Z)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime_to")]
        public string? DatetimeTo { get; set; }

        /// <summary>
        /// Filter from video timestamp in seconds (relative to video start)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_from")]
        public double? TimestampFrom { get; set; }

        /// <summary>
        /// Filter to video timestamp in seconds (relative to video start)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_to")]
        public double? TimestampTo { get; set; }

        /// <summary>
        /// Whether to generate a report and explanations for the search results<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_report")]
        public bool? GenerateReport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="threshold"></param>
        /// <param name="maxResults">
        /// Default Value: 10
        /// </param>
        /// <param name="videoIds"></param>
        /// <param name="groupIds"></param>
        /// <param name="searchDemo">
        /// Default Value: false
        /// </param>
        /// <param name="useLlmRerank">
        /// Default Value: false
        /// </param>
        /// <param name="useEmbedsRerank">
        /// Default Value: true
        /// </param>
        /// <param name="addOcrToCaption">
        /// Default Value: false
        /// </param>
        /// <param name="datetimeFrom">
        /// Filter from datetime (ISO 8601 format, e.g., 2024-01-15T10:00:00Z)
        /// </param>
        /// <param name="datetimeTo">
        /// Filter to datetime (ISO 8601 format, e.g., 2024-01-15T18:00:00Z)
        /// </param>
        /// <param name="timestampFrom">
        /// Filter from video timestamp in seconds (relative to video start)
        /// </param>
        /// <param name="timestampTo">
        /// Filter to video timestamp in seconds (relative to video start)
        /// </param>
        /// <param name="generateReport">
        /// Whether to generate a report and explanations for the search results<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequest(
            string query,
            double? threshold,
            int? maxResults,
            global::System.Collections.Generic.IList<string>? videoIds,
            global::System.Collections.Generic.IList<string>? groupIds,
            bool? searchDemo,
            bool? useLlmRerank,
            bool? useEmbedsRerank,
            bool? addOcrToCaption,
            string? datetimeFrom,
            string? datetimeTo,
            double? timestampFrom,
            double? timestampTo,
            bool? generateReport)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Threshold = threshold;
            this.MaxResults = maxResults;
            this.VideoIds = videoIds;
            this.GroupIds = groupIds;
            this.SearchDemo = searchDemo;
            this.UseLlmRerank = useLlmRerank;
            this.UseEmbedsRerank = useEmbedsRerank;
            this.AddOcrToCaption = addOcrToCaption;
            this.DatetimeFrom = datetimeFrom;
            this.DatetimeTo = datetimeTo;
            this.TimestampFrom = timestampFrom;
            this.TimestampTo = timestampTo;
            this.GenerateReport = generateReport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }

    }
}