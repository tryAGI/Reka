
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Result from hybrid search combining object and embedding search
    /// </summary>
    public sealed partial class VideoChunkSearchResult
    {
        /// <summary>
        /// Unique identifier for the video chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_chunk_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoChunkId { get; set; }

        /// <summary>
        /// Unique identifier for the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// User ID who owns the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Relevance score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoChunkSearchResultScoreJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.VideoChunkSearchResultScore Score { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public double? StartTimestamp { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public double? EndTimestamp { get; set; }

        /// <summary>
        /// Text caption for the video chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plain_text_caption")]
        public string? PlainTextCaption { get; set; }

        /// <summary>
        /// Transcription of speech in the video chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plain_text_transcript")]
        public string? PlainTextTranscript { get; set; }

        /// <summary>
        /// Presigned S3 URL to access the parent video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_presigned_url")]
        public string? S3PresignedUrl { get; set; }

        /// <summary>
        /// Title stored in the video's metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_title")]
        public string? VideoTitle { get; set; }

        /// <summary>
        /// URL (typically VTT) pointing to generated storyboard thumbnails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_thumbnails")]
        public string? VideoThumbnails { get; set; }

        /// <summary>
        /// Explanation of the video chunk content and its relevance to the search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoChunkSearchResult" /> class.
        /// </summary>
        /// <param name="videoChunkId">
        /// Unique identifier for the video chunk
        /// </param>
        /// <param name="videoId">
        /// Unique identifier for the video
        /// </param>
        /// <param name="userId">
        /// User ID who owns the video
        /// </param>
        /// <param name="score">
        /// Relevance score
        /// </param>
        /// <param name="startTimestamp">
        /// Start timestamp in seconds
        /// </param>
        /// <param name="endTimestamp">
        /// End timestamp in seconds
        /// </param>
        /// <param name="plainTextCaption">
        /// Text caption for the video chunk
        /// </param>
        /// <param name="plainTextTranscript">
        /// Transcription of speech in the video chunk
        /// </param>
        /// <param name="s3PresignedUrl">
        /// Presigned S3 URL to access the parent video
        /// </param>
        /// <param name="videoTitle">
        /// Title stored in the video's metadata
        /// </param>
        /// <param name="videoThumbnails">
        /// URL (typically VTT) pointing to generated storyboard thumbnails
        /// </param>
        /// <param name="explanation">
        /// Explanation of the video chunk content and its relevance to the search query
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoChunkSearchResult(
            string videoChunkId,
            string videoId,
            string userId,
            global::Reka.Vision.VideoChunkSearchResultScore score,
            double? startTimestamp,
            double? endTimestamp,
            string? plainTextCaption,
            string? plainTextTranscript,
            string? s3PresignedUrl,
            string? videoTitle,
            string? videoThumbnails,
            string? explanation)
        {
            this.VideoChunkId = videoChunkId ?? throw new global::System.ArgumentNullException(nameof(videoChunkId));
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Score = score;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.PlainTextCaption = plainTextCaption;
            this.PlainTextTranscript = plainTextTranscript;
            this.S3PresignedUrl = s3PresignedUrl;
            this.VideoTitle = videoTitle;
            this.VideoThumbnails = videoThumbnails;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoChunkSearchResult" /> class.
        /// </summary>
        public VideoChunkSearchResult()
        {
        }

    }
}