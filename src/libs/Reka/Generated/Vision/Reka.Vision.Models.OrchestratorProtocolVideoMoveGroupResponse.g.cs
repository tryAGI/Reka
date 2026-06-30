
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoMoveGroupResponse
    {
        /// <summary>
        /// Status of the move operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Number of videos moved to the target group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moved_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MovedCount { get; set; }

        /// <summary>
        /// Resolved destination group ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// Video IDs that were moved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VideoIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoMoveGroupResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the move operation
        /// </param>
        /// <param name="movedCount">
        /// Number of videos moved to the target group
        /// </param>
        /// <param name="groupId">
        /// Resolved destination group ID
        /// </param>
        /// <param name="videoIds">
        /// Video IDs that were moved
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoMoveGroupResponse(
            string status,
            int movedCount,
            string groupId,
            global::System.Collections.Generic.IList<string> videoIds)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.MovedCount = movedCount;
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.VideoIds = videoIds ?? throw new global::System.ArgumentNullException(nameof(videoIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoMoveGroupResponse" /> class.
        /// </summary>
        public OrchestratorProtocolVideoMoveGroupResponse()
        {
        }

    }
}