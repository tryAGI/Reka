
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoUploadResponse
    {
        /// <summary>
        /// Unique identifier for the uploaded video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// S3 URL of the uploaded video (null for background processing)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_s3_url")]
        public string? VideoS3Url { get; set; }

        /// <summary>
        /// Status of the upload<br/>
        /// Default Value: upload_initiated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoUploadResponse" /> class.
        /// </summary>
        /// <param name="videoId">
        /// Unique identifier for the uploaded video
        /// </param>
        /// <param name="videoS3Url">
        /// S3 URL of the uploaded video (null for background processing)
        /// </param>
        /// <param name="status">
        /// Status of the upload<br/>
        /// Default Value: upload_initiated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoUploadResponse(
            string videoId,
            string? videoS3Url,
            string? status)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.VideoS3Url = videoS3Url;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoUploadResponse" /> class.
        /// </summary>
        public OrchestratorProtocolVideoUploadResponse()
        {
        }

    }
}