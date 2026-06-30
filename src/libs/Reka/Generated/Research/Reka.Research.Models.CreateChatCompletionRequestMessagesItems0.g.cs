
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// Messages sent by an end user, containing prompts or additional context<br/>
    /// information.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestMessagesItems0
    {
        /// <summary>
        /// The role of the messages author, in this case `user`.<br/>
        /// Default Value: user
        /// </summary>
        /// <default>global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role.User</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf0RoleJsonConverter))]
        public global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role Role { get; set; } = global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role.User;

        /// <summary>
        /// The contents of the user message.
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
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestMessagesItems0" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the user message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `user`.<br/>
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestMessagesItems0(
            string content,
            global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role role = global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role.User)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestMessagesItems0" /> class.
        /// </summary>
        public CreateChatCompletionRequestMessagesItems0()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateChatCompletionRequestMessagesItems0"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateChatCompletionRequestMessagesItems0 FromContent(string content)
        {
            return new CreateChatCompletionRequestMessagesItems0
            {
                Content = content,
            };
        }

    }
}