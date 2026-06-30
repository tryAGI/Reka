
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoMetadata
    {
        /// <summary>
        /// Width of the video in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the video in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Average frames per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_fps")]
        public double? AvgFps { get; set; }

        /// <summary>
        /// Name of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// Title of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Start timestamp in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_start_timestamp_utc_ms")]
        public int? VideoStartTimestampUtcMs { get; set; }

        /// <summary>
        /// Duration of the video in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// URL to the video thumbnail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// URL, typically VTT, pointing to generated storyboard thumbnails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnails")]
        public string? Thumbnails { get; set; }

        /// <summary>
        /// Description of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Source path or URL of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the video in pixels
        /// </param>
        /// <param name="height">
        /// Height of the video in pixels
        /// </param>
        /// <param name="avgFps">
        /// Average frames per second
        /// </param>
        /// <param name="videoName">
        /// Name of the video
        /// </param>
        /// <param name="title">
        /// Title of the video
        /// </param>
        /// <param name="videoStartTimestampUtcMs">
        /// Start timestamp in milliseconds
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds
        /// </param>
        /// <param name="thumbnail">
        /// URL to the video thumbnail
        /// </param>
        /// <param name="thumbnails">
        /// URL, typically VTT, pointing to generated storyboard thumbnails
        /// </param>
        /// <param name="description">
        /// Description of the video
        /// </param>
        /// <param name="source">
        /// Source path or URL of the video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMetadata(
            int? width,
            int? height,
            double? avgFps,
            string? videoName,
            string? title,
            int? videoStartTimestampUtcMs,
            double? duration,
            string? thumbnail,
            string? thumbnails,
            string? description,
            string? source)
        {
            this.Width = width;
            this.Height = height;
            this.AvgFps = avgFps;
            this.VideoName = videoName;
            this.Title = title;
            this.VideoStartTimestampUtcMs = videoStartTimestampUtcMs;
            this.Duration = duration;
            this.Thumbnail = thumbnail;
            this.Thumbnails = thumbnails;
            this.Description = description;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        public VideoMetadata()
        {
        }

    }
}