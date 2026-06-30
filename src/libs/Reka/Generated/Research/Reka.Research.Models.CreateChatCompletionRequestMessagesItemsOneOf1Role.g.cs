
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The role of the messages author, in this case `assistant`.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum CreateChatCompletionRequestMessagesItemsOneOf1Role
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestMessagesItemsOneOf1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestMessagesItemsOneOf1Role value)
        {
            return value switch
            {
                CreateChatCompletionRequestMessagesItemsOneOf1Role.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestMessagesItemsOneOf1Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateChatCompletionRequestMessagesItemsOneOf1Role.Assistant,
                _ => null,
            };
        }
    }
}