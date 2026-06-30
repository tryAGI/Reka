
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentPrompt
    {
        /// <summary>
        /// Prompt type. Currently only 'text' is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.SegmentPromptTypeJsonConverter))]
        public global::Reka.Vision.SegmentPromptType Type { get; set; }

        /// <summary>
        /// What to detect (e.g., 'person', 'laptop', 'red car').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// What to detect (e.g., 'person', 'laptop', 'red car').
        /// </param>
        /// <param name="type">
        /// Prompt type. Currently only 'text' is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentPrompt(
            string text,
            global::Reka.Vision.SegmentPromptType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentPrompt" /> class.
        /// </summary>
        public SegmentPrompt()
        {
        }

    }
}