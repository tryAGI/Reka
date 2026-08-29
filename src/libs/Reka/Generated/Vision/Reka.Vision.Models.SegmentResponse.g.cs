
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SegmentResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.SegmentFrame> Frames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_size")]
        public global::Reka.Vision.FrameSize? FrameSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FrameCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentResponse" /> class.
        /// </summary>
        /// <param name="frames"></param>
        /// <param name="frameCount"></param>
        /// <param name="frameSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentResponse(
            global::System.Collections.Generic.IList<global::Reka.Vision.SegmentFrame> frames,
            int frameCount,
            global::Reka.Vision.FrameSize? frameSize)
        {
            this.Frames = frames ?? throw new global::System.ArgumentNullException(nameof(frames));
            this.FrameSize = frameSize;
            this.FrameCount = frameCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentResponse" /> class.
        /// </summary>
        public SegmentResponse()
        {
        }

    }
}