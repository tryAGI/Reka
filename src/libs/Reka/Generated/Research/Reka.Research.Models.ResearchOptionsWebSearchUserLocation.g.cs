
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The location to use for web searches. This can help the agent find results relevant to a specific area.
    /// </summary>
    public sealed partial class ResearchOptionsWebSearchUserLocation
    {
        /// <summary>
        /// The type of user location to use for web searches.<br/>
        /// Default Value: approximate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// An approximate location to use for web searches. This is useful when the exact location is not known, but a general area is desired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approximate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Research.ResearchOptionsWebSearchUserLocationApproximate Approximate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearchUserLocation" /> class.
        /// </summary>
        /// <param name="approximate">
        /// An approximate location to use for web searches. This is useful when the exact location is not known, but a general area is desired.
        /// </param>
        /// <param name="type">
        /// The type of user location to use for web searches.<br/>
        /// Default Value: approximate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOptionsWebSearchUserLocation(
            global::Reka.Research.ResearchOptionsWebSearchUserLocationApproximate approximate,
            string? type)
        {
            this.Type = type;
            this.Approximate = approximate ?? throw new global::System.ArgumentNullException(nameof(approximate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearchUserLocation" /> class.
        /// </summary>
        public ResearchOptionsWebSearchUserLocation()
        {
        }

    }
}