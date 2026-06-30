#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Upload Video<br/>
        /// Upload a video file or URL without triggering indexing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorApiV2ModelsVideoUploadResponse> UploadVideoV2VideosPostAsync(

            global::Reka.Vision.UploadVideoV2VideosPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Video<br/>
        /// Upload a video file or URL without triggering indexing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.OrchestratorApiV2ModelsVideoUploadResponse>> UploadVideoV2VideosPostAsResponseAsync(

            global::Reka.Vision.UploadVideoV2VideosPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Video<br/>
        /// Upload a video file or URL without triggering indexing.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="videoUrl">
        /// URL to download video from
        /// </param>
        /// <param name="videoName">
        /// Display name for the video. Required for file uploads.
        /// </param>
        /// <param name="groupId">
        /// ID of the video group to associate this video with
        /// </param>
        /// <param name="description">
        /// Video description
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorApiV2ModelsVideoUploadResponse> UploadVideoV2VideosPostAsync(
            byte[]? file = default,
            string? filename = default,
            string? videoUrl = default,
            string? videoName = default,
            string? groupId = default,
            string? description = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}