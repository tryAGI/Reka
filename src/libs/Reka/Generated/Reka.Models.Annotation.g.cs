
#nullable enable

namespace Reka
{
    /// <summary>
    /// A citation annotation referencing a web source.
    /// </summary>
    public sealed partial class Annotation
    {
        /// <summary>
        /// The annotation type. Always "url_citation".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.JsonConverters.AnnotationTypeJsonConverter))]
        public global::Reka.AnnotationType Type { get; set; }

        /// <summary>
        /// URL citation details with character-level positioning in the response content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        public global::Reka.UrlCitation? UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        /// <param name="type">
        /// The annotation type. Always "url_citation".
        /// </param>
        /// <param name="urlCitation">
        /// URL citation details with character-level positioning in the response content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Annotation(
            global::Reka.AnnotationType type,
            global::Reka.UrlCitation? urlCitation)
        {
            this.Type = type;
            this.UrlCitation = urlCitation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation" /> class.
        /// </summary>
        public Annotation()
        {
        }
    }
}