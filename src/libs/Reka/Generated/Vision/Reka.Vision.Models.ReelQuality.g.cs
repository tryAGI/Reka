
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReelQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Fallback,
        /// <summary>
        /// 
        /// </summary>
        FullVideo,
        /// <summary>
        /// 
        /// </summary>
        Lite,
        /// <summary>
        /// 
        /// </summary>
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReelQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReelQuality value)
        {
            return value switch
            {
                ReelQuality.Fallback => "fallback",
                ReelQuality.FullVideo => "full_video",
                ReelQuality.Lite => "lite",
                ReelQuality.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReelQuality? ToEnum(string value)
        {
            return value switch
            {
                "fallback" => ReelQuality.Fallback,
                "full_video" => ReelQuality.FullVideo,
                "lite" => ReelQuality.Lite,
                "premium" => ReelQuality.Premium,
                _ => null,
            };
        }
    }
}