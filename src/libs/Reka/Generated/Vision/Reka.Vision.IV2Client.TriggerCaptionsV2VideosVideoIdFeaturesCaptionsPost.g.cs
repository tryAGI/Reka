#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Trigger Captions<br/>
        /// Dispatch VLM captioning on video chunks.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerCaptionsV2VideosVideoIdFeaturesCaptionsPostAsync(
            string videoId,

            global::Reka.Vision.CaptionsTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Captions<br/>
        /// Dispatch VLM captioning on video chunks.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.FeatureTriggerResponse>> TriggerCaptionsV2VideosVideoIdFeaturesCaptionsPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.CaptionsTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Captions<br/>
        /// Dispatch VLM captioning on video chunks.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="captionPrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerCaptionsV2VideosVideoIdFeaturesCaptionsPostAsync(
            string videoId,
            bool? force = default,
            string? captionPrompt = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}