#nullable enable

namespace Reka.Vision
{
    public partial interface IMetadataTaggingClient
    {
        /// <summary>
        /// Quick Tag<br/>
        /// Generate metadata tags for short videos (under 30 seconds) without storage
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoTaggingAdvertisingResult> QuickTagV1QaQuicktagPostAsync(

            global::Reka.Vision.QuickTagV1QaQuicktagPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Quick Tag<br/>
        /// Generate metadata tags for short videos (under 30 seconds) without storage
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoTaggingAdvertisingResult>> QuickTagV1QaQuicktagPostAsResponseAsync(

            global::Reka.Vision.QuickTagV1QaQuicktagPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Quick Tag<br/>
        /// Generate metadata tags for short videos (under 30 seconds) without storage
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoTaggingAdvertisingResult> QuickTagV1QaQuicktagPostAsync(
            byte[] video,
            string videoname,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Quick Tag<br/>
        /// Generate metadata tags for short videos (under 30 seconds) without storage
        /// </summary>
        /// <param name="video">
        /// The stream to send as the multipart 'video' file part.
        /// </param>
        /// <param name="videoname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoTaggingAdvertisingResult> QuickTagV1QaQuicktagPostAsync(
            global::System.IO.Stream video,
            string videoname,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Quick Tag<br/>
        /// Generate metadata tags for short videos (under 30 seconds) without storage
        /// </summary>
        /// <param name="video">
        /// The stream to send as the multipart 'video' file part.
        /// </param>
        /// <param name="videoname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoTaggingAdvertisingResult>> QuickTagV1QaQuicktagPostAsResponseAsync(
            global::System.IO.Stream video,
            string videoname,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}