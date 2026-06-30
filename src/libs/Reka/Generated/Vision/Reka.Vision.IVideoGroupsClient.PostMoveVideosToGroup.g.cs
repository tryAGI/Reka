#nullable enable

namespace Reka.Vision
{
    public partial interface IVideoGroupsClient
    {
        /// <summary>
        /// Move Videos To Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoMoveGroupResponse> PostMoveVideosToGroupAsync(
            string groupId,

            global::Reka.Vision.OrchestratorProtocolVideoMoveGroupRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Videos To Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.OrchestratorProtocolVideoMoveGroupResponse>> PostMoveVideosToGroupAsResponseAsync(
            string groupId,

            global::Reka.Vision.OrchestratorProtocolVideoMoveGroupRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Videos To Group
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="videoIds">
        /// List of video IDs to move to the group identified by the route parameter.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoMoveGroupResponse> PostMoveVideosToGroupAsync(
            string groupId,
            global::System.Collections.Generic.IList<string> videoIds,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}