
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2SearchRequest
    {
        /// <summary>
        /// Search query — natural language for semantic, literal text for text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// 'semantic' (embedding similarity) or 'text' (literal substring match)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.SearchStrategyJsonConverter))]
        public global::Reka.Vision.SearchStrategy? Strategy { get; set; }

        /// <summary>
        /// Which data to search. For text: 'transcript', 'captions' (default: both). Ignored for semantic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::Reka.Vision.SearchTextField>? Fields { get; set; }

        /// <summary>
        /// Scope to specific video IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public global::System.Collections.Generic.IList<string>? VideoIds { get; set; }

        /// <summary>
        /// Scope to videos in specific groups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_ids")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// Confidence filter: high, medium, low, none. Only affects semantic strategy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.ThresholdLevelJsonConverter))]
        public global::Reka.Vision.ThresholdLevel? Threshold { get; set; }

        /// <summary>
        /// Apply embedding-based reranking (semantic only, slightly slower)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank")]
        public bool? Rerank { get; set; }

        /// <summary>
        /// Metadata filters (duration, width, height)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.SearchFilter, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.SearchFilter, object>? Filter { get; set; }

        /// <summary>
        /// Start of an explicit UTC datetime range for semantic search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime_from")]
        public global::System.DateTime? DatetimeFrom { get; set; }

        /// <summary>
        /// End of an explicit UTC datetime range for semantic search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime_to")]
        public global::System.DateTime? DatetimeTo { get; set; }

        /// <summary>
        /// Start of an explicit in-video timestamp range in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_from")]
        public double? TimestampFrom { get; set; }

        /// <summary>
        /// End of an explicit in-video timestamp range in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_to")]
        public double? TimestampTo { get; set; }

        /// <summary>
        /// Results per page (max 50)<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_limit")]
        public int? PageLimit { get; set; }

        /// <summary>
        /// Pagination token from a previous response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Generate LLM summary of results (semantic only)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_report")]
        public bool? IncludeReport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query — natural language for semantic, literal text for text
        /// </param>
        /// <param name="strategy">
        /// 'semantic' (embedding similarity) or 'text' (literal substring match)
        /// </param>
        /// <param name="fields">
        /// Which data to search. For text: 'transcript', 'captions' (default: both). Ignored for semantic.
        /// </param>
        /// <param name="videoIds">
        /// Scope to specific video IDs
        /// </param>
        /// <param name="groupIds">
        /// Scope to videos in specific groups
        /// </param>
        /// <param name="threshold">
        /// Confidence filter: high, medium, low, none. Only affects semantic strategy.
        /// </param>
        /// <param name="rerank">
        /// Apply embedding-based reranking (semantic only, slightly slower)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filter">
        /// Metadata filters (duration, width, height)
        /// </param>
        /// <param name="datetimeFrom">
        /// Start of an explicit UTC datetime range for semantic search
        /// </param>
        /// <param name="datetimeTo">
        /// End of an explicit UTC datetime range for semantic search
        /// </param>
        /// <param name="timestampFrom">
        /// Start of an explicit in-video timestamp range in seconds
        /// </param>
        /// <param name="timestampTo">
        /// End of an explicit in-video timestamp range in seconds
        /// </param>
        /// <param name="pageLimit">
        /// Results per page (max 50)<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="pageToken">
        /// Pagination token from a previous response
        /// </param>
        /// <param name="includeReport">
        /// Generate LLM summary of results (semantic only)<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2SearchRequest(
            string query,
            global::Reka.Vision.SearchStrategy? strategy,
            global::System.Collections.Generic.IList<global::Reka.Vision.SearchTextField>? fields,
            global::System.Collections.Generic.IList<string>? videoIds,
            global::System.Collections.Generic.IList<string>? groupIds,
            global::Reka.Vision.ThresholdLevel? threshold,
            bool? rerank,
            global::Reka.Vision.OneOf<global::Reka.Vision.SearchFilter, object>? filter,
            global::System.DateTime? datetimeFrom,
            global::System.DateTime? datetimeTo,
            double? timestampFrom,
            double? timestampTo,
            int? pageLimit,
            string? pageToken,
            bool? includeReport)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Strategy = strategy;
            this.Fields = fields;
            this.VideoIds = videoIds;
            this.GroupIds = groupIds;
            this.Threshold = threshold;
            this.Rerank = rerank;
            this.Filter = filter;
            this.DatetimeFrom = datetimeFrom;
            this.DatetimeTo = datetimeTo;
            this.TimestampFrom = timestampFrom;
            this.TimestampTo = timestampTo;
            this.PageLimit = pageLimit;
            this.PageToken = pageToken;
            this.IncludeReport = includeReport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchRequest" /> class.
        /// </summary>
        public V2SearchRequest()
        {
        }

    }
}