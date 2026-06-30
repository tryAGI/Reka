
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The role of the messages author, in this case `user`.<br/>
    /// Default Value: user
    /// </summary>
    public enum CreateChatCompletionRequestMessagesItemsOneOf0Role
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestMessagesItemsOneOf0RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestMessagesItemsOneOf0Role value)
        {
            return value switch
            {
                CreateChatCompletionRequestMessagesItemsOneOf0Role.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestMessagesItemsOneOf0Role? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateChatCompletionRequestMessagesItemsOneOf0Role.User,
                _ => null,
            };
        }
    }
}