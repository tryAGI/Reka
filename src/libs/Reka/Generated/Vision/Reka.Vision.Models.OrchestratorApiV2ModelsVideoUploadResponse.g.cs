
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorApiV2ModelsVideoUploadResponse
    {
        /// <summary>
        /// Unique identifier for the uploaded video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Status of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoUploadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.VideoUploadStatus Status { get; set; }

        /// <summary>
        /// Video metadata (populated after upload completes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorApiV2ModelsVideoUploadResponse" /> class.
        /// </summary>
        /// <param name="videoId">
        /// Unique identifier for the uploaded video
        /// </param>
        /// <param name="status">
        /// Status of the upload
        /// </param>
        /// <param name="metadata">
        /// Video metadata (populated after upload completes)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorApiV2ModelsVideoUploadResponse(
            string videoId,
            global::Reka.Vision.VideoUploadStatus status,
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>? metadata)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorApiV2ModelsVideoUploadResponse" /> class.
        /// </summary>
        public OrchestratorApiV2ModelsVideoUploadResponse()
        {
        }

    }
}