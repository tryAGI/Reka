
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// Configuration for web search capabilities. This allows the agent to perform web searches to gather information.
    /// </summary>
    public sealed partial class ResearchOptionsWebSearch
    {
        /// <summary>
        /// Whether to enable web search for the agent.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum number of web search queries the agent can make.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// A list of allowed domains for web search. If empty, all domains are allowed. If specified, the agent will only search within these domains. This is useful for restricting the agent to specific sources.<br/>
        /// For example, `["wikipedia.org", "reka.ai"]` would restrict searches to Wikipedia and Reka's website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// A list of blocked domains for web search. If specified, the agent will not search within these domains. This is useful for excluding specific sources from the agent's search results.<br/>
        /// For example, `["example.com"]` would block searches from example.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// The location to use for web searches. This can help the agent find results relevant to a specific area.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::Reka.Research.ResearchOptionsWebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearch" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to enable web search for the agent.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maxUses">
        /// The maximum number of web search queries the agent can make.
        /// </param>
        /// <param name="allowedDomains">
        /// A list of allowed domains for web search. If empty, all domains are allowed. If specified, the agent will only search within these domains. This is useful for restricting the agent to specific sources.<br/>
        /// For example, `["wikipedia.org", "reka.ai"]` would restrict searches to Wikipedia and Reka's website.
        /// </param>
        /// <param name="blockedDomains">
        /// A list of blocked domains for web search. If specified, the agent will not search within these domains. This is useful for excluding specific sources from the agent's search results.<br/>
        /// For example, `["example.com"]` would block searches from example.com.
        /// </param>
        /// <param name="userLocation">
        /// The location to use for web searches. This can help the agent find results relevant to a specific area.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchOptionsWebSearch(
            bool? enabled,
            int? maxUses,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::Reka.Research.ResearchOptionsWebSearchUserLocation? userLocation)
        {
            this.Enabled = enabled;
            this.MaxUses = maxUses;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOptionsWebSearch" /> class.
        /// </summary>
        public ResearchOptionsWebSearch()
        {
        }

    }
}