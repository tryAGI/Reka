
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTaggingRequest
    {
        /// <summary>
        /// ID of the video to tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTaggingRequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// ID of the video to tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTaggingRequest(
            string videoId)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTaggingRequest" /> class.
        /// </summary>
        public VideoTaggingRequest()
        {
        }

    }
}