
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorApiV2ModelsVideoMoveGroupRequest
    {
        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="OrchestratorApiV2ModelsVideoMoveGroupRequest" /> class.
        /// </summary>
        /// <param name="videoIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorApiV2ModelsVideoMoveGroupRequest(
            global::System.Collections.Generic.IList<string> videoIds)
        {
            this.VideoIds = videoIds ?? throw new global::System.ArgumentNullException(nameof(videoIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorApiV2ModelsVideoMoveGroupRequest" /> class.
        /// </summary>
        public OrchestratorApiV2ModelsVideoMoveGroupRequest()
        {
        }

    }
}