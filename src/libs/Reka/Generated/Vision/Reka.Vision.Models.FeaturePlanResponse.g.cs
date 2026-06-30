
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeaturePlanResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("all_required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.Feature> AllRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.FeatureStatus> Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.Feature> Actionable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.Feature> Processing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.Feature> Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reconfigure")]
        public global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.ReconfigureAction>? Reconfigure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.Dictionary<string, string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Done { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturePlanResponse" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="allRequired"></param>
        /// <param name="statuses"></param>
        /// <param name="actionable"></param>
        /// <param name="processing"></param>
        /// <param name="blocked"></param>
        /// <param name="done"></param>
        /// <param name="reconfigure"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeaturePlanResponse(
            string videoId,
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> allRequired,
            global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.FeatureStatus> statuses,
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> actionable,
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> processing,
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> blocked,
            bool done,
            global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.ReconfigureAction>? reconfigure,
            global::System.Collections.Generic.Dictionary<string, string>? errors)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.AllRequired = allRequired ?? throw new global::System.ArgumentNullException(nameof(allRequired));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
            this.Actionable = actionable ?? throw new global::System.ArgumentNullException(nameof(actionable));
            this.Processing = processing ?? throw new global::System.ArgumentNullException(nameof(processing));
            this.Blocked = blocked ?? throw new global::System.ArgumentNullException(nameof(blocked));
            this.Reconfigure = reconfigure;
            this.Errors = errors;
            this.Done = done;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturePlanResponse" /> class.
        /// </summary>
        public FeaturePlanResponse()
        {
        }

    }
}