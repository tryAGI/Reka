
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// An approximate location to use for web searches. This is useful when the exact location is not known, but a general area is desired.
    /// </summary>
    public sealed partial class ResearchOptionsWebSearchUserLocationApproximate
    {
        /// <summary>
        /// The city to use for web searches, e.g. `Sunnyvale`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The region to use for web searches, e.g. `California`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The country to use for web searches. The two-letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user, e.g. `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The timezone to use for web searches. The [IANA timezone](https://timeapi.io/documentation/iana-timezones) of the user, e.g. `America/California`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearchUserLocationApproximate" /> class.
        /// </summary>
        /// <param name="city">
        /// The city to use for web searches, e.g. `Sunnyvale`.
        /// </param>
        /// <param name="region">
        /// The region to use for web searches, e.g. `California`.
        /// </param>
        /// <param name="country">
        /// The country to use for web searches. The two-letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user, e.g. `US`.
        /// </param>
        /// <param name="timezone">
        /// The timezone to use for web searches. The [IANA timezone](https://timeapi.io/documentation/iana-timezones) of the user, e.g. `America/California`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOptionsWebSearchUserLocationApproximate(
            string? city,
            string? region,
            string? country,
            string? timezone)
        {
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearchUserLocationApproximate" /> class.
        /// </summary>
        public ResearchOptionsWebSearchUserLocationApproximate()
        {
        }

    }
}