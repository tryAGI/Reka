
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoQARequest
    {
        /// <summary>
        /// Override user ID. Takes precedence over API key header when provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The ID of the video to query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// The conversation history. The last message must be from the user and contain the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Reka.Vision.SimpleChatMessage>? Messages { get; set; }

        /// <summary>
        /// If true, stream the response using server-sent events (SSE).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// If true, apply temporal pre-filtering to narrow down the video timestamp search space.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_temporal_prefiltering")]
        public bool? ApplyTemporalPrefiltering { get; set; }

        /// <summary>
        /// If true, include demo videos in the QA flow.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_demo_videos")]
        public bool? IncludeDemoVideos { get; set; }

        /// <summary>
        /// If true, use map-reduce summarization instead of one-shot summarization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_map_reduce_summarization")]
        public bool? UseMapReduceSummarization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoQARequest" /> class.
        /// </summary>
        /// <param name="videoId">
        /// The ID of the video to query.
        /// </param>
        /// <param name="userId">
        /// Override user ID. Takes precedence over API key header when provided.
        /// </param>
        /// <param name="messages">
        /// The conversation history. The last message must be from the user and contain the query.
        /// </param>
        /// <param name="stream">
        /// If true, stream the response using server-sent events (SSE).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="applyTemporalPrefiltering">
        /// If true, apply temporal pre-filtering to narrow down the video timestamp search space.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeDemoVideos">
        /// If true, include demo videos in the QA flow.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="useMapReduceSummarization">
        /// If true, use map-reduce summarization instead of one-shot summarization.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoQARequest(
            string videoId,
            string? userId,
            global::System.Collections.Generic.IList<global::Reka.Vision.SimpleChatMessage>? messages,
            bool? stream,
            bool? applyTemporalPrefiltering,
            bool? includeDemoVideos,
            bool? useMapReduceSummarization)
        {
            this.UserId = userId;
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Messages = messages;
            this.Stream = stream;
            this.ApplyTemporalPrefiltering = applyTemporalPrefiltering;
            this.IncludeDemoVideos = includeDemoVideos;
            this.UseMapReduceSummarization = useMapReduceSummarization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoQARequest" /> class.
        /// </summary>
        public VideoQARequest()
        {
        }

    }
}