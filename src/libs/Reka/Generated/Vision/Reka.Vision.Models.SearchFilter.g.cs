
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Metadata filters applied to search results.
    /// </summary>
    public sealed partial class SearchFilter
    {
        /// <summary>
        /// Filter to specific video IDs (same as top-level video_ids)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Collections.Generic.IList<string>? Id { get; set; }

        /// <summary>
        /// Filter by video duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? Duration { get; set; }

        /// <summary>
        /// Filter by video width in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? Width { get; set; }

        /// <summary>
        /// Filter by video height in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilter" /> class.
        /// </summary>
        /// <param name="id">
        /// Filter to specific video IDs (same as top-level video_ids)
        /// </param>
        /// <param name="duration">
        /// Filter by video duration in seconds
        /// </param>
        /// <param name="width">
        /// Filter by video width in pixels
        /// </param>
        /// <param name="height">
        /// Filter by video height in pixels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchFilter(
            global::System.Collections.Generic.IList<string>? id,
            global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? duration,
            global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? width,
            global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>? height)
        {
            this.Id = id;
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilter" /> class.
        /// </summary>
        public SearchFilter()
        {
        }

    }
}