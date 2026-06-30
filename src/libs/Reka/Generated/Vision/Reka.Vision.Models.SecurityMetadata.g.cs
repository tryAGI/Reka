
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_id")]
        public string? CameraId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recorded_timestamp_utc")]
        public int? RecordedTimestampUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_clip_id")]
        public string? VideoClipId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_id")]
        public string? SiteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_metadata")]
        public global::System.Collections.Generic.IList<global::Reka.Vision.DetectionMetadata>? DetectionMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityMetadata" /> class.
        /// </summary>
        /// <param name="cameraId"></param>
        /// <param name="recordedTimestampUtc"></param>
        /// <param name="videoClipId"></param>
        /// <param name="orgId"></param>
        /// <param name="siteId"></param>
        /// <param name="eventId"></param>
        /// <param name="caption"></param>
        /// <param name="detectionMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityMetadata(
            string? cameraId,
            int? recordedTimestampUtc,
            string? videoClipId,
            string? orgId,
            string? siteId,
            string? eventId,
            string? caption,
            global::System.Collections.Generic.IList<global::Reka.Vision.DetectionMetadata>? detectionMetadata)
        {
            this.CameraId = cameraId;
            this.RecordedTimestampUtc = recordedTimestampUtc;
            this.VideoClipId = videoClipId;
            this.OrgId = orgId;
            this.SiteId = siteId;
            this.EventId = eventId;
            this.Caption = caption;
            this.DetectionMetadata = detectionMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityMetadata" /> class.
        /// </summary>
        public SecurityMetadata()
        {
        }

    }
}