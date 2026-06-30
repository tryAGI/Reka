
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechModelId
    {
        /// <summary>
        /// 
        /// </summary>
        ElevenV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechModelId value)
        {
            return value switch
            {
                TextToSpeechModelId.ElevenV3 => "eleven-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechModelId? ToEnum(string value)
        {
            return value switch
            {
                "eleven-v3" => TextToSpeechModelId.ElevenV3,
                _ => null,
            };
        }
    }
}