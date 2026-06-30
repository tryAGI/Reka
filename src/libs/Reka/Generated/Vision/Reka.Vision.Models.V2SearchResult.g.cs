
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2SearchResult
    {
        /// <summary>
        /// Video this moment is from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Video display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Relevance score in [0, 1]. Text matches are binary; 1.0 is a sentinel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Position in results (1 = most relevant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// AI description of the visual content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Spoken words in this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Preview frame URL (not yet available)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// Presigned URL to the parent video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchResult" /> class.
        /// </summary>
        /// <param name="videoId">
        /// Video this moment is from
        /// </param>
        /// <param name="score">
        /// Relevance score in [0, 1]. Text matches are binary; 1.0 is a sentinel.
        /// </param>
        /// <param name="rank">
        /// Position in results (1 = most relevant)
        /// </param>
        /// <param name="videoName">
        /// Video display name
        /// </param>
        /// <param name="start">
        /// Start time in seconds
        /// </param>
        /// <param name="end">
        /// End time in seconds
        /// </param>
        /// <param name="caption">
        /// AI description of the visual content
        /// </param>
        /// <param name="transcript">
        /// Spoken words in this segment
        /// </param>
        /// <param name="thumbnailUrl">
        /// Preview frame URL (not yet available)
        /// </param>
        /// <param name="videoUrl">
        /// Presigned URL to the parent video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2SearchResult(
            string videoId,
            double score,
            int rank,
            string? videoName,
            double? start,
            double? end,
            string? caption,
            string? transcript,
            string? thumbnailUrl,
            string? videoUrl)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.VideoName = videoName;
            this.Start = start;
            this.End = end;
            this.Score = score;
            this.Rank = rank;
            this.Caption = caption;
            this.Transcript = transcript;
            this.ThumbnailUrl = thumbnailUrl;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2SearchResult" /> class.
        /// </summary>
        public V2SearchResult()
        {
        }

    }
}