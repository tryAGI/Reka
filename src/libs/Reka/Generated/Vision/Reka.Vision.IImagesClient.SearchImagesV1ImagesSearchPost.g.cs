#nullable enable

namespace Reka.Vision
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Search Images<br/>
        /// Search for images with a plaintext query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.ImageSearchResponse> SearchImagesV1ImagesSearchPostAsync(

            global::Reka.Vision.ImageSearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Images<br/>
        /// Search for images with a plaintext query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.ImageSearchResponse>> SearchImagesV1ImagesSearchPostAsResponseAsync(

            global::Reka.Vision.ImageSearchRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Images<br/>
        /// Search for images with a plaintext query
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.ImageSearchResponse> SearchImagesV1ImagesSearchPostAsync(
            string query,
            int? maxResults = default,
            global::Reka.Vision.ImageSearchRequestSearchMode? searchMode = default,
            double? imageWeight = default,
            double? textWeight = default,
            double? threshold = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}