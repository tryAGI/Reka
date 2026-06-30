#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Segment
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.SegmentResponse> SegmentV2VideosVideoIdSegmentPostAsync(
            string videoId,

            global::Reka.Vision.SegmentRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Segment
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.SegmentResponse>> SegmentV2VideosVideoIdSegmentPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.SegmentRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Segment
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="prompts">
        /// Objects to detect. Each prompt is run against every sampled frame.
        /// </param>
        /// <param name="start">
        /// Start of time range in seconds.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="end">
        /// End of time range in seconds. Defaults to start + 15s, clamped to video duration. Max range is 15 seconds.
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold. Detections below this score are excluded.<br/>
        /// Default Value: 0.3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.SegmentResponse> SegmentV2VideosVideoIdSegmentPostAsync(
            string videoId,
            global::System.Collections.Generic.IList<global::Reka.Vision.SegmentPrompt> prompts,
            double? start = default,
            double? end = default,
            double? threshold = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}