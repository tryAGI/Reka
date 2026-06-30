
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionFontConfigPosition
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        Middle,
        /// <summary>
        /// 
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionFontConfigPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionFontConfigPosition value)
        {
            return value switch
            {
                CaptionFontConfigPosition.Bottom => "bottom",
                CaptionFontConfigPosition.Middle => "middle",
                CaptionFontConfigPosition.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionFontConfigPosition? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => CaptionFontConfigPosition.Bottom,
                "middle" => CaptionFontConfigPosition.Middle,
                "top" => CaptionFontConfigPosition.Top,
                _ => null,
            };
        }
    }
}