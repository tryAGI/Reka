
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoGroupListResponse
    {
        /// <summary>
        /// List of video groups
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupListResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// List of video groups
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoGroupListResponse(
            global::System.Collections.Generic.IList<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupListResponse" /> class.
        /// </summary>
        public OrchestratorProtocolVideoGroupListResponse()
        {
        }

    }
}