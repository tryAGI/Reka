#nullable enable

namespace Reka.Vision
{
    public partial interface IVideoQaClient
    {
        /// <summary>
        /// Chat<br/>
        /// Chat with the video QA model.<br/>
        /// Set `stream=true` to receive server-sent events (SSE) instead of a single response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoQAResponse> ChatV1QaChatPostAsync(

            global::Reka.Vision.VideoQARequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// Chat with the video QA model.<br/>
        /// Set `stream=true` to receive server-sent events (SSE) instead of a single response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.VideoQAResponse>> ChatV1QaChatPostAsResponseAsync(

            global::Reka.Vision.VideoQARequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// Chat with the video QA model.<br/>
        /// Set `stream=true` to receive server-sent events (SSE) instead of a single response.
        /// </summary>
        /// <param name="userId">
        /// Override user ID. Takes precedence over API key header when provided.
        /// </param>
        /// <param name="videoId">
        /// The ID of the video to query.
        /// </param>
        /// <param name="messages">
        /// The conversation history. The last message must be from the user and contain the query.
        /// </param>
        /// <param name="stream">
        /// If true, stream the response using server-sent events (SSE).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="applyTemporalPrefiltering">
        /// If true, apply temporal pre-filtering to narrow down the video timestamp search space.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeDemoVideos">
        /// If true, include demo videos in the QA flow.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useMapReduceSummarization">
        /// If true, use map-reduce summarization instead of one-shot summarization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.VideoQAResponse> ChatV1QaChatPostAsync(
            string videoId,
            string? userId = default,
            global::System.Collections.Generic.IList<global::Reka.Vision.SimpleChatMessage>? messages = default,
            bool? stream = default,
            bool? applyTemporalPrefiltering = default,
            bool? includeDemoVideos = default,
            bool? useMapReduceSummarization = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}