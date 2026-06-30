
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Prompt type. Currently only 'text' is supported.
    /// </summary>
    public enum SegmentPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentPromptType value)
        {
            return value switch
            {
                SegmentPromptType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentPromptType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SegmentPromptType.Text,
                _ => null,
            };
        }
    }
}