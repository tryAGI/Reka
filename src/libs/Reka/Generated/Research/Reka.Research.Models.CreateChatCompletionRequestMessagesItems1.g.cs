
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// Messages sent by the agent in response to user messages.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestMessagesItems1
    {
        /// <summary>
        /// The role of the messages author, in this case `assistant`.<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf1RoleJsonConverter))]
        public global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role Role { get; set; } = global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role.Assistant;

        /// <summary>
        /// The contents of the assistant message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestMessagesItems1" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the assistant message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `assistant`.<br/>
        /// Default Value: assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestMessagesItems1(
            string content,
            global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role role = global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role.Assistant)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestMessagesItems1" /> class.
        /// </summary>
        public CreateChatCompletionRequestMessagesItems1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateChatCompletionRequestMessagesItems1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateChatCompletionRequestMessagesItems1 FromContent(string content)
        {
            return new CreateChatCompletionRequestMessagesItems1
            {
                Content = content,
            };
        }

    }
}