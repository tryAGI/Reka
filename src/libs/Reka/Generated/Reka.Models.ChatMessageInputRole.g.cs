
#nullable enable

namespace Reka
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    public enum ChatMessageInputRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageInputRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageInputRole value)
        {
            return value switch
            {
                ChatMessageInputRole.User => "user",
                ChatMessageInputRole.Assistant => "assistant",
                ChatMessageInputRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageInputRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatMessageInputRole.User,
                "assistant" => ChatMessageInputRole.Assistant,
                "tool" => ChatMessageInputRole.Tool,
                _ => null,
            };
        }
    }
}