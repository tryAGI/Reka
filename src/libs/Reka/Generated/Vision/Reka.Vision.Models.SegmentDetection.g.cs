
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentDetection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.SegmentBoundingBox Bbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentDetection" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="promptIndex"></param>
        /// <param name="score"></param>
        /// <param name="bbox"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentDetection(
            string label,
            int promptIndex,
            double score,
            global::Reka.Vision.SegmentBoundingBox bbox)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PromptIndex = promptIndex;
            this.Score = score;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentDetection" /> class.
        /// </summary>
        public SegmentDetection()
        {
        }

    }
}