
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPool
    {
        /// <summary>
        /// Number of videos searched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VideoCount { get; set; }

        /// <summary>
        /// Total duration searched (seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPool" /> class.
        /// </summary>
        /// <param name="videoCount">
        /// Number of videos searched
        /// </param>
        /// <param name="totalDuration">
        /// Total duration searched (seconds)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPool(
            int videoCount,
            double totalDuration)
        {
            this.VideoCount = videoCount;
            this.TotalDuration = totalDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPool" /> class.
        /// </summary>
        public SearchPool()
        {
        }

    }
}