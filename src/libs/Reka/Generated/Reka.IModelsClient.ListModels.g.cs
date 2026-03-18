#nullable enable

namespace Reka
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models<br/>
        /// List models available to the user. Different users may have access to different models depending on their permissions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.ListModelsResponse> ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}