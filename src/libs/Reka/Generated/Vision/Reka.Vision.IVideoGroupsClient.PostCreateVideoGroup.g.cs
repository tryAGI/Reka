#nullable enable

namespace Reka.Vision
{
    public partial interface IVideoGroupsClient
    {
        /// <summary>
        /// Create Video Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> PostCreateVideoGroupAsync(

            global::Reka.Vision.OrchestratorProtocolVideoGroupCreateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse>> PostCreateVideoGroupAsResponseAsync(

            global::Reka.Vision.OrchestratorProtocolVideoGroupCreateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Group
        /// </summary>
        /// <param name="name">
        /// Name for the new video group
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to attach to the newly created group
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> PostCreateVideoGroupAsync(
            string name,
            object? metadata = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}