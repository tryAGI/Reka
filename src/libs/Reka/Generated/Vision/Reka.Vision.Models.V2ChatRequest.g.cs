
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2ChatRequest
    {
        /// <summary>
        /// Conversation history. The last message must be from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.ChatMessage> Messages { get; set; }

        /// <summary>
        /// Videos to analyze. Each entry references a video, optionally with a time range for visual analysis. At least one required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.ChatVideoContext> Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Conversation history. The last message must be from the user.
        /// </param>
        /// <param name="context">
        /// Videos to analyze. Each entry references a video, optionally with a time range for visual analysis. At least one required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2ChatRequest(
            global::System.Collections.Generic.IList<global::Reka.Vision.ChatMessage> messages,
            global::System.Collections.Generic.IList<global::Reka.Vision.ChatVideoContext> context)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ChatRequest" /> class.
        /// </summary>
        public V2ChatRequest()
        {
        }

    }
}