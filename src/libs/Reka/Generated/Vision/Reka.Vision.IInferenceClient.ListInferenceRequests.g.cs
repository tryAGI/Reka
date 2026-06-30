#nullable enable

namespace Reka.Vision
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// List inference requests
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="capability"></param>
        /// <param name="modelId"></param>
        /// <param name="status"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="expand"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.InferenceRequestListResponse> ListInferenceRequestsAsync(
            string? endpointId = default,
            string? capability = default,
            string? modelId = default,
            global::Reka.Vision.OneOf<global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?, object>? status = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            int? limit = default,
            int? offset = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List inference requests
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="capability"></param>
        /// <param name="modelId"></param>
        /// <param name="status"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="expand"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.InferenceRequestListResponse>> ListInferenceRequestsAsResponseAsync(
            string? endpointId = default,
            string? capability = default,
            string? modelId = default,
            global::Reka.Vision.OneOf<global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?, object>? status = default,
            global::System.DateTime? start = default,
            global::System.DateTime? end = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            int? limit = default,
            int? offset = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}