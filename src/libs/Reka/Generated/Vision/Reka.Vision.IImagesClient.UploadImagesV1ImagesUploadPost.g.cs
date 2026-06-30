#nullable enable

namespace Reka.Vision
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Upload Images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.ImageUploadBatchResponse> UploadImagesV1ImagesUploadPostAsync(

            global::Reka.Vision.UploadImagesV1ImagesUploadPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.ImageUploadBatchResponse>> UploadImagesV1ImagesUploadPostAsResponseAsync(

            global::Reka.Vision.UploadImagesV1ImagesUploadPostRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Images
        /// </summary>
        /// <param name="images">
        /// List of images to upload (optional if image_urls are provided)
        /// </param>
        /// <param name="metadata">
        /// JSON string of metadata list matching image order
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.ImageUploadBatchResponse> UploadImagesV1ImagesUploadPostAsync(
            string metadata,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}