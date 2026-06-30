
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceRequestListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.InferenceRequestListItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_offset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextOffset"></param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRequestListResponse(
            global::System.Collections.Generic.IList<global::Reka.Vision.InferenceRequestListItem> items,
            int? nextOffset,
            bool? hasMore)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextOffset = nextOffset;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestListResponse" /> class.
        /// </summary>
        public InferenceRequestListResponse()
        {
        }

    }
}