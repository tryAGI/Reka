#nullable enable

namespace Reka.Vision
{
    public partial interface IMetadataTaggingClient
    {
        /// <summary>
        /// Indexed Tag<br/>
        /// Generate metadata tags for previously indexed videos
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200> IndexedTagV1QaIndexedtagPostAsync(

            global::Reka.Vision.VideoTaggingRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Indexed Tag<br/>
        /// Generate metadata tags for previously indexed videos
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200>> IndexedTagV1QaIndexedtagPostAsResponseAsync(

            global::Reka.Vision.VideoTaggingRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Indexed Tag<br/>
        /// Generate metadata tags for previously indexed videos
        /// </summary>
        /// <param name="videoId">
        /// ID of the video to tag
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200> IndexedTagV1QaIndexedtagPostAsync(
            string videoId,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}