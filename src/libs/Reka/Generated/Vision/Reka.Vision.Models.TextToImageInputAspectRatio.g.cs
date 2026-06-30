
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: 1:1
    /// </summary>
    public enum TextToImageInputAspectRatio
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
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageInputAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageInputAspectRatio value)
        {
            return value switch
            {
                TextToImageInputAspectRatio.x16_9 => "16:9",
                TextToImageInputAspectRatio.x1_1 => "1:1",
                TextToImageInputAspectRatio.x21_9 => "21:9",
                TextToImageInputAspectRatio.x2_3 => "2:3",
                TextToImageInputAspectRatio.x3_2 => "3:2",
                TextToImageInputAspectRatio.x3_4 => "3:4",
                TextToImageInputAspectRatio.x4_3 => "4:3",
                TextToImageInputAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageInputAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => TextToImageInputAspectRatio.x16_9,
                "1:1" => TextToImageInputAspectRatio.x1_1,
                "21:9" => TextToImageInputAspectRatio.x21_9,
                "2:3" => TextToImageInputAspectRatio.x2_3,
                "3:2" => TextToImageInputAspectRatio.x3_2,
                "3:4" => TextToImageInputAspectRatio.x3_4,
                "4:3" => TextToImageInputAspectRatio.x4_3,
                "9:16" => TextToImageInputAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}