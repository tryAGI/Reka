
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToBboxOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.BoundingBox> Bboxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToBboxOutput" /> class.
        /// </summary>
        /// <param name="bboxes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToBboxOutput(
            global::System.Collections.Generic.IList<global::Reka.Vision.BoundingBox> bboxes)
        {
            this.Bboxes = bboxes ?? throw new global::System.ArgumentNullException(nameof(bboxes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToBboxOutput" /> class.
        /// </summary>
        public ImageToBboxOutput()
        {
        }

    }
}