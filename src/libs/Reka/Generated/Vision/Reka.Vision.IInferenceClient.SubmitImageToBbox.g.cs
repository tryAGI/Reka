#nullable enable

namespace Reka.Vision
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Submit Image To Bbox
        /// </summary>
        /// <param name="model"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.SubmitResponse> SubmitImageToBboxAsync(
            global::Reka.Vision.ImageToBboxModelId model,

            global::Reka.Vision.ImageToBboxSubmitRequest request,
            string? idempotencyKey = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Image To Bbox
        /// </summary>
        /// <param name="model"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.SubmitResponse>> SubmitImageToBboxAsResponseAsync(
            global::Reka.Vision.ImageToBboxModelId model,

            global::Reka.Vision.ImageToBboxSubmitRequest request,
            string? idempotencyKey = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Image To Bbox
        /// </summary>
        /// <param name="model"></param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="input"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.SubmitResponse> SubmitImageToBboxAsync(
            global::Reka.Vision.ImageToBboxModelId model,
            global::Reka.Vision.ImageToBboxInput input,
            string? idempotencyKey = default,
            string? webhookUrl = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}