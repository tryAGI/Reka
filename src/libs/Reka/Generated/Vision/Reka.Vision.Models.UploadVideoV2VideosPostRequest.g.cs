
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadVideoV2VideosPostRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// URL to download video from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Display name for the video. Required for file uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// ID of the video group to associate this video with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Video description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadVideoV2VideosPostRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="videoUrl">
        /// URL to download video from
        /// </param>
        /// <param name="videoName">
        /// Display name for the video. Required for file uploads.
        /// </param>
        /// <param name="groupId">
        /// ID of the video group to associate this video with
        /// </param>
        /// <param name="description">
        /// Video description
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadVideoV2VideosPostRequest(
            byte[]? file,
            string? filename,
            string? videoUrl,
            string? videoName,
            string? groupId,
            string? description)
        {
            this.File = file;
            this.Filename = filename;
            this.VideoUrl = videoUrl;
            this.VideoName = videoName;
            this.GroupId = groupId;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadVideoV2VideosPostRequest" /> class.
        /// </summary>
        public UploadVideoV2VideosPostRequest()
        {
        }

    }
}