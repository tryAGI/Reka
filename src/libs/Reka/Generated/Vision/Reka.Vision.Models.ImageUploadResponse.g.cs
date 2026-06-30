
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IndexingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UploadTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUploadResponse" /> class.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="imageUrl"></param>
        /// <param name="indexingStatus"></param>
        /// <param name="uploadTimestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageUploadResponse(
            string imageId,
            string imageUrl,
            int indexingStatus,
            double uploadTimestamp)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.IndexingStatus = indexingStatus;
            this.UploadTimestamp = uploadTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUploadResponse" /> class.
        /// </summary>
        public ImageUploadResponse()
        {
        }

    }
}