
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    /// </summary>
    public enum CreateChatCompletionStreamResponseChoicesItemsFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseChoicesItemsFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseChoicesItemsFinishReason value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseChoicesItemsFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseChoicesItemsFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "stop" => CreateChatCompletionStreamResponseChoicesItemsFinishReason.Stop,
                _ => null,
            };
        }
    }
}