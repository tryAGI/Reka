#nullable enable

namespace Reka.Vision
{
    public partial interface IVideoSearchClient
    {
        /// <summary>
        /// Embedding Search<br/>
        /// Embedding-based search with temporal extraction support.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoSearchResponse> PostEmbeddingSearchAsync(

            global::Reka.Vision.SearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embedding Search<br/>
        /// Embedding-based search with temporal extraction support.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoSearchResponse>> PostEmbeddingSearchAsResponseAsync(

            global::Reka.Vision.SearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embedding Search<br/>
        /// Embedding-based search with temporal extraction support.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoSearchResponse> PostEmbeddingSearchAsync(
            string query,
            double? threshold = default,
            int? maxResults = default,
            global::System.Collections.Generic.IList<string>? videoIds = default,
            global::System.Collections.Generic.IList<string>? groupIds = default,
            bool? searchDemo = default,
            bool? useLlmRerank = default,
            bool? useEmbedsRerank = default,
            bool? addOcrToCaption = default,
            string? datetimeFrom = default,
            string? datetimeTo = default,
            double? timestampFrom = default,
            double? timestampTo = default,
            bool? generateReport = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}