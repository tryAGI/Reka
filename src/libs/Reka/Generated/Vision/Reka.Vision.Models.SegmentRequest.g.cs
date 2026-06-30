
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentRequest
    {
        /// <summary>
        /// Objects to detect. Each prompt is run against every sampled frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.SegmentPrompt> Prompts { get; set; }

        /// <summary>
        /// Start of time range in seconds.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// End of time range in seconds. Defaults to start + 15s, clamped to video duration. Max range is 15 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Confidence threshold. Detections below this score are excluded.<br/>
        /// Default Value: 0.3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentRequest" /> class.
        /// </summary>
        /// <param name="prompts">
        /// Objects to detect. Each prompt is run against every sampled frame.
        /// </param>
        /// <param name="start">
        /// Start of time range in seconds.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="end">
        /// End of time range in seconds. Defaults to start + 15s, clamped to video duration. Max range is 15 seconds.
        /// </param>
        /// <param name="threshold">
        /// Confidence threshold. Detections below this score are excluded.<br/>
        /// Default Value: 0.3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentRequest(
            global::System.Collections.Generic.IList<global::Reka.Vision.SegmentPrompt> prompts,
            double? start,
            double? end,
            double? threshold)
        {
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
            this.Start = start;
            this.End = end;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentRequest" /> class.
        /// </summary>
        public SegmentRequest()
        {
        }

    }
}