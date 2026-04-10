#nullable enable

namespace Reka
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models<br/>
        /// List models available to the user. Different users may have access to different models depending on their permissions.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.ListModelsResponse> ListModelsAsync(
            global::Reka.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}