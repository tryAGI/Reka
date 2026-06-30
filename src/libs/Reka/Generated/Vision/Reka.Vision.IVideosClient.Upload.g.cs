#nullable enable

namespace Reka.Vision
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Upload Video<br/>
        /// Upload a new video for search and Q&amp;A.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoUploadResponse> UploadAsync(

            global::Reka.Vision.UploadRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Video<br/>
        /// Upload a new video for search and Q&amp;A.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.OrchestratorProtocolVideoUploadResponse>> UploadAsResponseAsync(

            global::Reka.Vision.UploadRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Video<br/>
        /// Upload a new video for search and Q&amp;A.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="videoUrl">
        /// Video URL for Reka to download from before indexing, for e.g. https://sample-videos.com/video321/mp4/720/big_buck_bunny_720p_1mb.mp4
        /// </param>
        /// <param name="index">
        /// A boolean flag to indicate whether or not to index the provided video
        /// </param>
        /// <param name="enableThumbnails">
        /// A boolean flag to indicate whether or not to index the enable thumbnails when indexing the video<br/>
        /// Default Value: false
        /// </param>
        /// <param name="videoName">
        /// A name to associate with your video. Required for file uploads, optional for URL uploads
        /// </param>
        /// <param name="videoAbsoluteStartTimestamp">
        /// The real-world timestamp when the video recording started, in ISO 8601 format (e.g., '2024-01-01T00:00:00Z')
        /// </param>
        /// <param name="config">
        /// JSON string containing VideoIndexingParams configuration for advanced indexing options
        /// </param>
        /// <param name="personIndexing">
        /// Whether to enable person/object detection and indexing for the video.
        /// </param>
        /// <param name="persistFrames">
        /// Whether to persist extracted video frames for later retrieval
        /// </param>
        /// <param name="captionPrompt">
        /// Custom prompt to use when generating captions for video segments
        /// </param>
        /// <param name="encodeChunks">
        /// Whether to encode video chunks during indexing
        /// </param>
        /// <param name="captionMode">
        /// Predefined caption mode to use for generating captions
        /// </param>
        /// <param name="groupId">
        /// ID of the video group to associate this video with
        /// </param>
        /// <param name="chunkingConfig">
        /// JSON string containing ChunkingConfig for custom video chunking behavior
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.OrchestratorProtocolVideoUploadResponse> UploadAsync(
            bool index,
            byte[]? file = default,
            string? filename = default,
            string? videoUrl = default,
            bool? enableThumbnails = default,
            string? videoName = default,
            string? videoAbsoluteStartTimestamp = default,
            string? config = default,
            bool? personIndexing = default,
            bool? persistFrames = default,
            string? captionPrompt = default,
            bool? encodeChunks = default,
            global::Reka.Vision.CaptionMode? captionMode = default,
            string? groupId = default,
            string? chunkingConfig = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}