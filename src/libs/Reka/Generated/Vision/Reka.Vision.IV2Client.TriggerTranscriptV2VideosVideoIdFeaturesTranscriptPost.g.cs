#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Trigger Transcript<br/>
        /// Trigger chunking for a video. Returns transcript feature status.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerTranscriptV2VideosVideoIdFeaturesTranscriptPostAsync(
            string videoId,

            global::Reka.Vision.TranscriptTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Transcript<br/>
        /// Trigger chunking for a video. Returns transcript feature status.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.FeatureTriggerResponse>> TriggerTranscriptV2VideosVideoIdFeaturesTranscriptPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.TranscriptTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Transcript<br/>
        /// Trigger chunking for a video. Returns transcript feature status.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="chunkingConfig"></param>
        /// <param name="downsampleVideo">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerTranscriptV2VideosVideoIdFeaturesTranscriptPostAsync(
            string videoId,
            bool? force = default,
            global::Reka.Vision.ChunkingConfigInput? chunkingConfig = default,
            bool? downsampleVideo = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}