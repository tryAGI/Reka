#nullable enable

namespace Reka.Vision
{
    public partial interface IClipsClient
    {
        /// <summary>
        /// Create Reel<br/>
        /// Generate highlight reels from longer videos
        /// </summary>
        /// <param name="reelQuality"></param>
        /// <param name="forceVllmWhisperAsr">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateReelV1ClipsPostAsync(

            global::Reka.Vision.ClipRequest request,
            global::Reka.Vision.ReelQuality? reelQuality = default,
            bool? forceVllmWhisperAsr = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reel<br/>
        /// Generate highlight reels from longer videos
        /// </summary>
        /// <param name="reelQuality"></param>
        /// <param name="forceVllmWhisperAsr">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<string>> CreateReelV1ClipsPostAsResponseAsync(

            global::Reka.Vision.ClipRequest request,
            global::Reka.Vision.ReelQuality? reelQuality = default,
            bool? forceVllmWhisperAsr = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reel<br/>
        /// Generate highlight reels from longer videos
        /// </summary>
        /// <param name="reelQuality"></param>
        /// <param name="forceVllmWhisperAsr">
        /// Default Value: false
        /// </param>
        /// <param name="videoUrls">
        /// List of video URLs to process
        /// </param>
        /// <param name="prompt">
        /// Prompt for video generation<br/>
        /// Default Value: Create an engaging short video highlighting the best moments
        /// </param>
        /// <param name="generationConfig">
        /// Grouped generation configuration
        /// </param>
        /// <param name="renderingConfig">
        /// Grouped rendering configuration
        /// </param>
        /// <param name="stream">
        /// Whether to stream the generation process<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateReelV1ClipsPostAsync(
            global::System.Collections.Generic.IList<string> videoUrls,
            global::Reka.Vision.ReelQuality? reelQuality = default,
            bool? forceVllmWhisperAsr = default,
            string? prompt = default,
            global::Reka.Vision.ClipGenerationConfig? generationConfig = default,
            global::Reka.Vision.ClipRenderingConfig? renderingConfig = default,
            bool? stream = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}