
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureTriggerResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.FeatureJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.Feature Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.FeatureStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.FeatureStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTriggerResponse" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="feature"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureTriggerResponse(
            string videoId,
            global::Reka.Vision.Feature feature,
            global::Reka.Vision.FeatureStatus status)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Feature = feature;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTriggerResponse" /> class.
        /// </summary>
        public FeatureTriggerResponse()
        {
        }

    }
}