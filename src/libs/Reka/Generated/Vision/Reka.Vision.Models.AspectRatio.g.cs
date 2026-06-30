
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum AspectRatio
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
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x9_16Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.x16_9 => "16:9",
                AspectRatio.x1_1 => "1:1",
                AspectRatio.x4_5 => "4:5",
                AspectRatio.x9_16 => "9:16",
                AspectRatio.x9_16Split => "9:16-split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AspectRatio.x16_9,
                "1:1" => AspectRatio.x1_1,
                "4:5" => AspectRatio.x4_5,
                "9:16" => AspectRatio.x9_16,
                "9:16-split" => AspectRatio.x9_16Split,
                _ => null,
            };
        }
    }
}