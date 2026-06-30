
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Lightweight response model for list endpoint.
    /// </summary>
    public sealed partial class ClipListItem
    {
        /// <summary>
        /// Unique identifier for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Current status of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// List of input video URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_urls")]
        public global::System.Collections.Generic.IList<string>? VideoUrls { get; set; }

        /// <summary>
        /// Prompt used for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generation
        /// </param>
        /// <param name="status">
        /// Current status of the generation
        /// </param>
        /// <param name="videoUrls">
        /// List of input video URLs
        /// </param>
        /// <param name="prompt">
        /// Prompt used for generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipListItem(
            string id,
            string status,
            global::System.Collections.Generic.IList<string>? videoUrls,
            string? prompt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.VideoUrls = videoUrls;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipListItem" /> class.
        /// </summary>
        public ClipListItem()
        {
        }

    }
}