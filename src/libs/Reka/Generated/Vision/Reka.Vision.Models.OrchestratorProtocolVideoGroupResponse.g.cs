
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoGroupResponse
    {
        /// <summary>
        /// Unique identifier for the video group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Name of the video group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Arbitrary metadata attached to the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when group was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when group was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupResponse" /> class.
        /// </summary>
        /// <param name="groupId">
        /// Unique identifier for the video group
        /// </param>
        /// <param name="name">
        /// Name of the video group
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata attached to the group
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when group was created
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp when group was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoGroupResponse(
            string groupId,
            string name,
            object? metadata,
            string? createdAt,
            string? updatedAt)
        {
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupResponse" /> class.
        /// </summary>
        public OrchestratorProtocolVideoGroupResponse()
        {
        }

    }
}