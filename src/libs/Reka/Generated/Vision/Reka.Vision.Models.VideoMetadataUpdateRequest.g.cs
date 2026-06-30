
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoMetadataUpdateRequest
    {
        /// <summary>
        /// Updated display name for the video. This is the name shown in listings and search results. Pass null to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated title for the video. Pass null to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Updated description for the video. Pass null to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Move the video to this group. Pass null to leave unchanged. The group must exist and belong to the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated display name for the video. This is the name shown in listings and search results. Pass null to leave unchanged.
        /// </param>
        /// <param name="title">
        /// Updated title for the video. Pass null to leave unchanged.
        /// </param>
        /// <param name="description">
        /// Updated description for the video. Pass null to leave unchanged.
        /// </param>
        /// <param name="groupId">
        /// Move the video to this group. Pass null to leave unchanged. The group must exist and belong to the authenticated user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMetadataUpdateRequest(
            string? name,
            string? title,
            string? description,
            string? groupId)
        {
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataUpdateRequest" /> class.
        /// </summary>
        public VideoMetadataUpdateRequest()
        {
        }

    }
}