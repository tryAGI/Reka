#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Update Video Metadata<br/>
        /// Update a video's metadata (name/title/description) and optionally move group.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoResponse> UpdateVideoMetadataV2VideosVideoIdPatchAsync(
            global::System.Guid videoId,

            global::Reka.Vision.VideoMetadataUpdateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Video Metadata<br/>
        /// Update a video's metadata (name/title/description) and optionally move group.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoResponse>> UpdateVideoMetadataV2VideosVideoIdPatchAsResponseAsync(
            global::System.Guid videoId,

            global::Reka.Vision.VideoMetadataUpdateRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Video Metadata<br/>
        /// Update a video's metadata (name/title/description) and optionally move group.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="name">
        /// Updated display name for the video. This is the name shown in listings and search results. Pass null to leave unchanged.
        /// </param>
        /// <param name="title">
        /// Updated title for the video. Pass null to leave unchanged.
        /// </param>
        /// <param name="description">
        /// Updated description for the video. Pass null to leave unchanged.
        /// </param>
        /// <param name="groupId">
        /// Move the video to this group. Pass null to leave unchanged. The group must exist and belong to the authenticated user.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoResponse> UpdateVideoMetadataV2VideosVideoIdPatchAsync(
            global::System.Guid videoId,
            string? name = default,
            string? title = default,
            string? description = default,
            string? groupId = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}