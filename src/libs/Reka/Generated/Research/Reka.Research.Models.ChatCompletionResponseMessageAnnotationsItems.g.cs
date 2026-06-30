
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// A URL citation.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessageAnnotationsItems
    {
        /// <summary>
        /// The type of the URL citation. Always `url_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.ChatCompletionResponseMessageAnnotationsItemsTypeJsonConverter))]
        public global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType Type { get; set; }

        /// <summary>
        /// A URL citation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsUrlCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotationsItems" /> class.
        /// </summary>
        /// <param name="urlCitation">
        /// A URL citation.
        /// </param>
        /// <param name="type">
        /// The type of the URL citation. Always `url_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseMessageAnnotationsItems(
            global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsUrlCitation urlCitation,
            global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType type)
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessageAnnotationsItems" /> class.
        /// </summary>
        public ChatCompletionResponseMessageAnnotationsItems()
        {
        }

    }
}