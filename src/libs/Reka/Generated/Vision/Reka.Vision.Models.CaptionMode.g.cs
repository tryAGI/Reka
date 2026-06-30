
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Generic,
        /// <summary>
        /// 
        /// </summary>
        Security,
        /// <summary>
        /// 
        /// </summary>
        TaggingAdVideo,
        /// <summary>
        /// 
        /// </summary>
        Tte1110,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionMode value)
        {
            return value switch
            {
                CaptionMode.Generic => "generic",
                CaptionMode.Security => "security",
                CaptionMode.TaggingAdVideo => "tagging_ad_video",
                CaptionMode.Tte1110 => "tte_1110",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionMode? ToEnum(string value)
        {
            return value switch
            {
                "generic" => CaptionMode.Generic,
                "security" => CaptionMode.Security,
                "tagging_ad_video" => CaptionMode.TaggingAdVideo,
                "tte_1110" => CaptionMode.Tte1110,
                _ => null,
            };
        }
    }
}