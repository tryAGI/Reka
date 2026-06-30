
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: 16:9
    /// </summary>
    public enum TextToVideoInputAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoInputAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoInputAspectRatio value)
        {
            return value switch
            {
                TextToVideoInputAspectRatio.x16_9 => "16:9",
                TextToVideoInputAspectRatio.x1_1 => "1:1",
                TextToVideoInputAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoInputAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => TextToVideoInputAspectRatio.x16_9,
                "1:1" => TextToVideoInputAspectRatio.x1_1,
                "9:16" => TextToVideoInputAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}