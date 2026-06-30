#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Captions
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pageLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.PaginatedResponseCaptionEntry> ListCaptionsV2VideosVideoIdCaptionsGetAsync(
            string videoId,
            double? start = default,
            double? end = default,
            int? pageLimit = default,
            string? pageToken = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Captions
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pageLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="pageToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.PaginatedResponseCaptionEntry>> ListCaptionsV2VideosVideoIdCaptionsGetAsResponseAsync(
            string videoId,
            double? start = default,
            double? end = default,
            int? pageLimit = default,
            string? pageToken = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}