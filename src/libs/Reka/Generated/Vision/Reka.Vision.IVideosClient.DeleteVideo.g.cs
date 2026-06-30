#nullable enable

namespace Reka.Vision
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Delete Video By Id<br/>
        /// Delete a single video by ID.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoDeleteResponse> DeleteVideoAsync(
            string videoId,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Video By Id<br/>
        /// Delete a single video by ID.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoDeleteResponse>> DeleteVideoAsResponseAsync(
            string videoId,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}