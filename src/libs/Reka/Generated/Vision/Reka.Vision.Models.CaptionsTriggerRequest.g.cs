
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionsTriggerRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption_prompt")]
        public string? CaptionPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionsTriggerRequest" /> class.
        /// </summary>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="captionPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionsTriggerRequest(
            bool? force,
            string? captionPrompt)
        {
            this.Force = force;
            this.CaptionPrompt = captionPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionsTriggerRequest" /> class.
        /// </summary>
        public CaptionsTriggerRequest()
        {
        }

    }
}