
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadRequest
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
        /// Video URL for Reka to download from before indexing, for e.g. https://sample-videos.com/video321/mp4/720/big_buck_bunny_720p_1mb.mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// A boolean flag to indicate whether or not to index the provided video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Index { get; set; }

        /// <summary>
        /// A boolean flag to indicate whether or not to index the enable thumbnails when indexing the video<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thumbnails")]
        public bool? EnableThumbnails { get; set; }

        /// <summary>
        /// A name to associate with your video. Required for file uploads, optional for URL uploads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_name")]
        public string? VideoName { get; set; }

        /// <summary>
        /// The real-world timestamp when the video recording started, in ISO 8601 format (e.g., '2024-01-01T00:00:00Z')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_absolute_start_timestamp")]
        public string? VideoAbsoluteStartTimestamp { get; set; }

        /// <summary>
        /// JSON string containing VideoIndexingParams configuration for advanced indexing options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public string? Config { get; set; }

        /// <summary>
        /// Whether to enable person/object detection and indexing for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_indexing")]
        public bool? PersonIndexing { get; set; }

        /// <summary>
        /// Whether to persist extracted video frames for later retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist_frames")]
        public bool? PersistFrames { get; set; }

        /// <summary>
        /// Custom prompt to use when generating captions for video segments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption_prompt")]
        public string? CaptionPrompt { get; set; }

        /// <summary>
        /// Whether to encode video chunks during indexing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encode_chunks")]
        public bool? EncodeChunks { get; set; }

        /// <summary>
        /// Predefined caption mode to use for generating captions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.CaptionModeJsonConverter))]
        public global::Reka.Vision.CaptionMode? CaptionMode { get; set; }

        /// <summary>
        /// ID of the video group to associate this video with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// JSON string containing ChunkingConfig for custom video chunking behavior
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_config")]
        public string? ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        /// <param name="index">
        /// A boolean flag to indicate whether or not to index the provided video
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="videoUrl">
        /// Video URL for Reka to download from before indexing, for e.g. https://sample-videos.com/video321/mp4/720/big_buck_bunny_720p_1mb.mp4
        /// </param>
        /// <param name="enableThumbnails">
        /// A boolean flag to indicate whether or not to index the enable thumbnails when indexing the video<br/>
        /// Default Value: false
        /// </param>
        /// <param name="videoName">
        /// A name to associate with your video. Required for file uploads, optional for URL uploads
        /// </param>
        /// <param name="videoAbsoluteStartTimestamp">
        /// The real-world timestamp when the video recording started, in ISO 8601 format (e.g., '2024-01-01T00:00:00Z')
        /// </param>
        /// <param name="config">
        /// JSON string containing VideoIndexingParams configuration for advanced indexing options
        /// </param>
        /// <param name="personIndexing">
        /// Whether to enable person/object detection and indexing for the video.
        /// </param>
        /// <param name="persistFrames">
        /// Whether to persist extracted video frames for later retrieval
        /// </param>
        /// <param name="captionPrompt">
        /// Custom prompt to use when generating captions for video segments
        /// </param>
        /// <param name="encodeChunks">
        /// Whether to encode video chunks during indexing
        /// </param>
        /// <param name="captionMode">
        /// Predefined caption mode to use for generating captions
        /// </param>
        /// <param name="groupId">
        /// ID of the video group to associate this video with
        /// </param>
        /// <param name="chunkingConfig">
        /// JSON string containing ChunkingConfig for custom video chunking behavior
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadRequest(
            bool index,
            byte[]? file,
            string? filename,
            string? videoUrl,
            bool? enableThumbnails,
            string? videoName,
            string? videoAbsoluteStartTimestamp,
            string? config,
            bool? personIndexing,
            bool? persistFrames,
            string? captionPrompt,
            bool? encodeChunks,
            global::Reka.Vision.CaptionMode? captionMode,
            string? groupId,
            string? chunkingConfig)
        {
            this.File = file;
            this.Filename = filename;
            this.VideoUrl = videoUrl;
            this.Index = index;
            this.EnableThumbnails = enableThumbnails;
            this.VideoName = videoName;
            this.VideoAbsoluteStartTimestamp = videoAbsoluteStartTimestamp;
            this.Config = config;
            this.PersonIndexing = personIndexing;
            this.PersistFrames = persistFrames;
            this.CaptionPrompt = captionPrompt;
            this.EncodeChunks = encodeChunks;
            this.CaptionMode = captionMode;
            this.GroupId = groupId;
            this.ChunkingConfig = chunkingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        public UploadRequest()
        {
        }

    }
}