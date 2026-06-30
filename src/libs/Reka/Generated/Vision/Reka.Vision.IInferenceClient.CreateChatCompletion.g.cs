#nullable enable

namespace Reka.Vision
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// OpenAI-compatible chat completion (Qwen)<br/>
        /// Sync OpenAI-compatible chat completion proxied to DashScope.<br/>
        /// Set `stream=true` for SSE; the response preserves OpenAI's exact wire<br/>
        /// framing so `openai.OpenAI(base_url=".../v2/inference")` clients work<br/>
        /// unchanged. Meters one `vision/inference` event per non-error response<br/>
        /// with token counts as properties.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateChatCompletionAsync(

            global::Reka.Vision.ChatCompletionRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI-compatible chat completion (Qwen)<br/>
        /// Sync OpenAI-compatible chat completion proxied to DashScope.<br/>
        /// Set `stream=true` for SSE; the response preserves OpenAI's exact wire<br/>
        /// framing so `openai.OpenAI(base_url=".../v2/inference")` clients work<br/>
        /// unchanged. Meters one `vision/inference` event per non-error response<br/>
        /// with token counts as properties.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<string>> CreateChatCompletionAsResponseAsync(

            global::Reka.Vision.ChatCompletionRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI-compatible chat completion (Qwen)<br/>
        /// Sync OpenAI-compatible chat completion proxied to DashScope.<br/>
        /// Set `stream=true` for SSE; the response preserves OpenAI's exact wire<br/>
        /// framing so `openai.OpenAI(base_url=".../v2/inference")` clients work<br/>
        /// unchanged. Meters one `vision/inference` event per non-error response<br/>
        /// with token counts as properties.
        /// </summary>
        /// <param name="model">
        /// Allow-listed Qwen model id.
        /// </param>
        /// <param name="messages">
        /// OpenAI chat messages array.
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<object> messages,
            bool? stream = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}