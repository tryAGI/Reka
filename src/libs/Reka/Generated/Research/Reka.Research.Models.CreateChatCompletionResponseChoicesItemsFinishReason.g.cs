
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The reason the agent stopped generating tokens. <br/>
    /// This will be `stop` if the agent hit a natural stop point or a provided stop sequence.
    /// </summary>
    public enum CreateChatCompletionResponseChoicesItemsFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionResponseChoicesItemsFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionResponseChoicesItemsFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionResponseChoicesItemsFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionResponseChoicesItemsFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionResponseChoicesItemsFinishReason.Stop,
                _ => null,
            };
        }
    }
}