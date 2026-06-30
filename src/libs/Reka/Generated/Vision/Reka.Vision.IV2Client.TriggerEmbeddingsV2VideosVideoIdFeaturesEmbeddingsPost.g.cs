#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Trigger Embeddings<br/>
        /// Dispatch vector embedding computation for semantic search.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerEmbeddingsV2VideosVideoIdFeaturesEmbeddingsPostAsync(
            string videoId,

            global::Reka.Vision.FeatureTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Embeddings<br/>
        /// Dispatch vector embedding computation for semantic search.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.FeatureTriggerResponse>> TriggerEmbeddingsV2VideosVideoIdFeaturesEmbeddingsPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.FeatureTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Embeddings<br/>
        /// Dispatch vector embedding computation for semantic search.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerEmbeddingsV2VideosVideoIdFeaturesEmbeddingsPostAsync(
            string videoId,
            bool? force = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}