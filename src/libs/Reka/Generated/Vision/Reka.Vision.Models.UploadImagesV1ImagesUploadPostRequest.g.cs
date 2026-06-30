
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadImagesV1ImagesUploadPostRequest
    {
        /// <summary>
        /// List of images to upload (optional if image_urls are provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// JSON string of metadata list matching image order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImagesV1ImagesUploadPostRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// JSON string of metadata list matching image order
        /// </param>
        /// <param name="images">
        /// List of images to upload (optional if image_urls are provided)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadImagesV1ImagesUploadPostRequest(
            string metadata,
            global::System.Collections.Generic.IList<byte[]>? images)
        {
            this.Images = images;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImagesV1ImagesUploadPostRequest" /> class.
        /// </summary>
        public UploadImagesV1ImagesUploadPostRequest()
        {
        }

    }
}