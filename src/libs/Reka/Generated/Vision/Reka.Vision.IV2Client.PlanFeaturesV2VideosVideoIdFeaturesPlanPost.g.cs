#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Plan Features<br/>
        /// Given desired features, return what the agent can trigger next.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeaturePlanResponse> PlanFeaturesV2VideosVideoIdFeaturesPlanPostAsync(
            string videoId,

            global::Reka.Vision.FeaturePlanRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Plan Features<br/>
        /// Given desired features, return what the agent can trigger next.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.FeaturePlanResponse>> PlanFeaturesV2VideosVideoIdFeaturesPlanPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.FeaturePlanRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Plan Features<br/>
        /// Given desired features, return what the agent can trigger next.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="desired"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeaturePlanResponse> PlanFeaturesV2VideosVideoIdFeaturesPlanPostAsync(
            string videoId,
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> desired,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}