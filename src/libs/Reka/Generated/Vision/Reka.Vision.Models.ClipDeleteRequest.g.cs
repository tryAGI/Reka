
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipDeleteRequest
    {
        /// <summary>
        /// Whether to delete the indexed source video along with the generation<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_input_video")]
        public bool? DeleteInputVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipDeleteRequest" /> class.
        /// </summary>
        /// <param name="deleteInputVideo">
        /// Whether to delete the indexed source video along with the generation<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipDeleteRequest(
            bool? deleteInputVideo)
        {
            this.DeleteInputVideo = deleteInputVideo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipDeleteRequest" /> class.
        /// </summary>
        public ClipDeleteRequest()
        {
        }

    }
}