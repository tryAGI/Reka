
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoGroupUpdateRequest
    {
        /// <summary>
        /// New name for the video group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated metadata for the video group. Pass null to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the video group
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the video group. Pass null to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoGroupUpdateRequest(
            string? name,
            object? metadata)
        {
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupUpdateRequest" /> class.
        /// </summary>
        public OrchestratorProtocolVideoGroupUpdateRequest()
        {
        }

    }
}