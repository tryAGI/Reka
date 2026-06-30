#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.V2SearchResponse> SearchV2SearchPostAsync(

            global::Reka.Vision.V2SearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.V2SearchResponse>> SearchV2SearchPostAsResponseAsync(

            global::Reka.Vision.V2SearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.V2SearchResponse> SearchV2SearchPostAsync(
            string query,
            global::Reka.Vision.SearchStrategy? strategy = default,
            global::System.Collections.Generic.IList<global::Reka.Vision.SearchTextField>? fields = default,
            global::System.Collections.Generic.IList<string>? videoIds = default,
            global::System.Collections.Generic.IList<string>? groupIds = default,
            global::Reka.Vision.ThresholdLevel? threshold = default,
            bool? rerank = default,
            global::Reka.Vision.OneOf<global::Reka.Vision.SearchFilter, object>? filter = default,
            global::System.DateTime? datetimeFrom = default,
            global::System.DateTime? datetimeTo = default,
            double? timestampFrom = default,
            double? timestampTo = default,
            int? pageLimit = default,
            string? pageToken = default,
            bool? includeReport = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}