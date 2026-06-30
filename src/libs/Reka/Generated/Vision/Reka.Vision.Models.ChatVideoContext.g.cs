
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatVideoContext
    {
        /// <summary>
        /// The video to analyze
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Start of time range in seconds. When provided, enables visual analysis (frame extraction). Typically from search_videos results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End of time range in seconds. If omitted and start is set, defaults to start + 10 seconds (clamped to video duration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatVideoContext" /> class.
        /// </summary>
        /// <param name="videoId">
        /// The video to analyze
        /// </param>
        /// <param name="start">
        /// Start of time range in seconds. When provided, enables visual analysis (frame extraction). Typically from search_videos results.
        /// </param>
        /// <param name="end">
        /// End of time range in seconds. If omitted and start is set, defaults to start + 10 seconds (clamped to video duration).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatVideoContext(
            string videoId,
            double? start,
            double? end)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatVideoContext" /> class.
        /// </summary>
        public ChatVideoContext()
        {
        }

    }
}