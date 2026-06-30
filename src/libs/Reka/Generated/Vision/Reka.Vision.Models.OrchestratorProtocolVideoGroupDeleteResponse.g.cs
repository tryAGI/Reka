
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrchestratorProtocolVideoGroupDeleteResponse
    {
        /// <summary>
        /// Status of the deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Status message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupDeleteResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the deletion
        /// </param>
        /// <param name="message">
        /// Status message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrchestratorProtocolVideoGroupDeleteResponse(
            string status,
            string? message)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorProtocolVideoGroupDeleteResponse" /> class.
        /// </summary>
        public OrchestratorProtocolVideoGroupDeleteResponse()
        {
        }

    }
}