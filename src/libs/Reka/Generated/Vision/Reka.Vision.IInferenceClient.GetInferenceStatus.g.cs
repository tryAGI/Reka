#nullable enable

namespace Reka.Vision
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Get inference status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="withLogs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.StatusResponse> GetInferenceStatusAsync(
            string requestId,
            bool? withLogs = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get inference status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="withLogs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.StatusResponse>> GetInferenceStatusAsResponseAsync(
            string requestId,
            bool? withLogs = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}