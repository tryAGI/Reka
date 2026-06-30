
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSearchResult
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
        [global::System.Text.Json.Serialization.JsonPropertyName("image_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.SecurityMetadata ImageMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UploadTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResult" /> class.
        /// </summary>
        /// <param name="imageId"></param>
        /// <param name="imageUrl"></param>
        /// <param name="imageMetadata"></param>
        /// <param name="uploadTimestamp"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSearchResult(
            string imageId,
            string imageUrl,
            global::Reka.Vision.SecurityMetadata imageMetadata,
            double uploadTimestamp,
            double? score)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.ImageMetadata = imageMetadata ?? throw new global::System.ArgumentNullException(nameof(imageMetadata));
            this.UploadTimestamp = uploadTimestamp;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchResult" /> class.
        /// </summary>
        public ImageSearchResult()
        {
        }

    }
}