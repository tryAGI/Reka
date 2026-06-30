
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Detection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_id")]
        public int? PersonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Bbox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FrameIdx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_timestamp_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameTimestampStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_timestamp_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrameTimestampEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Detection" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="bbox"></param>
        /// <param name="frameIdx"></param>
        /// <param name="frameTimestampStart"></param>
        /// <param name="frameTimestampEnd"></param>
        /// <param name="personId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Detection(
            string type,
            global::System.Collections.Generic.IList<int> bbox,
            int frameIdx,
            double frameTimestampStart,
            double frameTimestampEnd,
            int? personId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PersonId = personId;
            this.Bbox = bbox ?? throw new global::System.ArgumentNullException(nameof(bbox));
            this.FrameIdx = frameIdx;
            this.FrameTimestampStart = frameTimestampStart;
            this.FrameTimestampEnd = frameTimestampEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Detection" /> class.
        /// </summary>
        public Detection()
        {
        }

    }
}