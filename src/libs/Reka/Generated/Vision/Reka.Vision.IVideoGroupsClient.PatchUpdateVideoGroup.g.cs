#nullable enable

namespace Reka.Vision
{
    public partial interface IVideoGroupsClient
    {
        /// <summary>
        /// Update Video Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> PatchUpdateVideoGroupAsync(
            string groupId,

            global::Reka.Vision.OrchestratorProtocolVideoGroupUpdateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Video Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse>> PatchUpdateVideoGroupAsResponseAsync(
            string groupId,

            global::Reka.Vision.OrchestratorProtocolVideoGroupUpdateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Video Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="name">
        /// New name for the video group
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the video group. Pass null to leave unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> PatchUpdateVideoGroupAsync(
            string groupId,
            string? name = default,
            object? metadata = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}