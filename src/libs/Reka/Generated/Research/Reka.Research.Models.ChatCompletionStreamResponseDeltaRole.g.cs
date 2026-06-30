
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The role of the author of this message.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum ChatCompletionStreamResponseDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionStreamResponseDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamResponseDeltaRole value)
        {
            return value switch
            {
                ChatCompletionStreamResponseDeltaRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionStreamResponseDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionStreamResponseDeltaRole.Assistant,
                _ => null,
            };
        }
    }
}