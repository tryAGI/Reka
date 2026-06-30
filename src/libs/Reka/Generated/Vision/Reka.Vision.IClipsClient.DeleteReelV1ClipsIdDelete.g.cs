#nullable enable

namespace Reka.Vision
{
    public partial interface IClipsClient
    {
        /// <summary>
        /// Delete Reel<br/>
        /// Delete a completed or failed reel generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, bool>> DeleteReelV1ClipsIdDeleteAsync(
            global::System.Guid id,

            global::Reka.Vision.ClipDeleteRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Reel<br/>
        /// Delete a completed or failed reel generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, bool>>> DeleteReelV1ClipsIdDeleteAsResponseAsync(
            global::System.Guid id,

            global::Reka.Vision.ClipDeleteRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Reel<br/>
        /// Delete a completed or failed reel generation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deleteInputVideo">
        /// Whether to delete the indexed source video along with the generation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, bool>> DeleteReelV1ClipsIdDeleteAsync(
            global::System.Guid id,
            bool? deleteInputVideo = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}