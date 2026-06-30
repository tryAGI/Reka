
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionFontConfigFontFamily
    {
        /// <summary>
        /// 
        /// </summary>
        Bangers,
        /// <summary>
        /// 
        /// </summary>
        BebasNeue,
        /// <summary>
        /// 
        /// </summary>
        CaptionFont,
        /// <summary>
        /// 
        /// </summary>
        Lato,
        /// <summary>
        /// 
        /// </summary>
        RobotoCondensed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionFontConfigFontFamilyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionFontConfigFontFamily value)
        {
            return value switch
            {
                CaptionFontConfigFontFamily.Bangers => "Bangers",
                CaptionFontConfigFontFamily.BebasNeue => "BebasNeue",
                CaptionFontConfigFontFamily.CaptionFont => "CaptionFont",
                CaptionFontConfigFontFamily.Lato => "Lato",
                CaptionFontConfigFontFamily.RobotoCondensed => "RobotoCondensed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionFontConfigFontFamily? ToEnum(string value)
        {
            return value switch
            {
                "Bangers" => CaptionFontConfigFontFamily.Bangers,
                "BebasNeue" => CaptionFontConfigFontFamily.BebasNeue,
                "CaptionFont" => CaptionFontConfigFontFamily.CaptionFont,
                "Lato" => CaptionFontConfigFontFamily.Lato,
                "RobotoCondensed" => CaptionFontConfigFontFamily.RobotoCondensed,
                _ => null,
            };
        }
    }
}