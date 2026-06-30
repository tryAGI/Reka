
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideosGetResponseChunk
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Metadata for a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? Metadata { get; set; }

        /// <summary>
        /// Status of video indexing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoIndexingStatus?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoIndexingStatus?, object>? IndexingStatus { get; set; }

        /// <summary>
        /// Type of indexing applied to the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.UserIndexingParams?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.UserIndexingParams?, object>? IndexingType { get; set; }

        /// <summary>
        /// Group ID if video belongs to a group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosGetResponseChunk" /> class.
        /// </summary>
        /// <param name="videoId">
        /// Unique identifier for the video
        /// </param>
        /// <param name="url">
        /// Presigned S3 URL to access the video
        /// </param>
        /// <param name="metadata">
        /// Metadata for a video
        /// </param>
        /// <param name="indexingStatus">
        /// Status of video indexing
        /// </param>
        /// <param name="indexingType">
        /// Type of indexing applied to the video
        /// </param>
        /// <param name="groupId">
        /// Group ID if video belongs to a group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideosGetResponseChunk(
            string videoId,
            string url,
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? metadata,
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoIndexingStatus?, object>? indexingStatus,
            global::Reka.Vision.OneOf<global::Reka.Vision.UserIndexingParams?, object>? indexingType,
            string? groupId)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Metadata = metadata;
            this.IndexingStatus = indexingStatus;
            this.IndexingType = indexingType;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideosGetResponseChunk" /> class.
        /// </summary>
        public VideosGetResponseChunk()
        {
        }

    }
}