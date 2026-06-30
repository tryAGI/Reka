
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.SegmentDetection> Detections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentFrame" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="detections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentFrame(
            double timestamp,
            global::System.Collections.Generic.IList<global::Reka.Vision.SegmentDetection> detections)
        {
            this.Timestamp = timestamp;
            this.Detections = detections ?? throw new global::System.ArgumentNullException(nameof(detections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentFrame" /> class.
        /// </summary>
        public SegmentFrame()
        {
        }

    }
}