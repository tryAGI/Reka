
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoResponse
    {
        /// <summary>
        /// Unique identifier for the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Presigned S3 URL to access the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Upload status of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoUploadStatus?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoUploadStatus?, object>? Status { get; set; }

        /// <summary>
        /// Metadata for a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? Metadata { get; set; }

        /// <summary>
        /// Per-feature indexing statuses from the video_features table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.FeatureStatus>? Features { get; set; }

        /// <summary>
        /// Group ID if video belongs to a group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Error message if upload/download failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        /// <param name="videoId">
        /// Unique identifier for the video
        /// </param>
        /// <param name="url">
        /// Presigned S3 URL to access the video
        /// </param>
        /// <param name="status">
        /// Upload status of the video
        /// </param>
        /// <param name="metadata">
        /// Metadata for a video
        /// </param>
        /// <param name="features">
        /// Per-feature indexing statuses from the video_features table
        /// </param>
        /// <param name="groupId">
        /// Group ID if video belongs to a group
        /// </param>
        /// <param name="error">
        /// Error message if upload/download failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResponse(
            string videoId,
            string? url,
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoUploadStatus?, object>? status,
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? metadata,
            global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.FeatureStatus>? features,
            string? groupId,
            string? error)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Url = url;
            this.Status = status;
            this.Metadata = metadata;
            this.Features = features;
            this.GroupId = groupId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        public VideoResponse()
        {
        }

    }
}