
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoQAResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoQaResponseChatResponse?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VideoQaResponseChatResponse?, object>? ChatResponse { get; set; }

        /// <summary>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoQaResponseStatusJsonConverter))]
        public global::Reka.Vision.VideoQaResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoQAResponse" /> class.
        /// </summary>
        /// <param name="chatResponse"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoQAResponse(
            global::Reka.Vision.OneOf<global::Reka.Vision.VideoQaResponseChatResponse?, object>? chatResponse,
            global::Reka.Vision.VideoQaResponseStatus? status)
        {
            this.ChatResponse = chatResponse;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoQAResponse" /> class.
        /// </summary>
        public VideoQAResponse()
        {
        }

    }
}