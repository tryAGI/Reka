
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoGroupCreateRequest
    {
        /// <summary>
        /// Name for the new video group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional metadata to attach to the newly created group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new video group
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to attach to the newly created group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoGroupCreateRequest(
            string name,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupCreateRequest" /> class.
        /// </summary>
        public OrchestratorProtocolVideoGroupCreateRequest()
        {
        }

    }
}