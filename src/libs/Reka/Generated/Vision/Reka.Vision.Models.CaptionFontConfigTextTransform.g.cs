
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionFontConfigTextTransform
    {
        /// <summary>
        /// 
        /// </summary>
        Initial,
        /// <summary>
        /// 
        /// </summary>
        Lowercase,
        /// <summary>
        /// 
        /// </summary>
        Uppercase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionFontConfigTextTransformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionFontConfigTextTransform value)
        {
            return value switch
            {
                CaptionFontConfigTextTransform.Initial => "initial",
                CaptionFontConfigTextTransform.Lowercase => "lowercase",
                CaptionFontConfigTextTransform.Uppercase => "uppercase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionFontConfigTextTransform? ToEnum(string value)
        {
            return value switch
            {
                "initial" => CaptionFontConfigTextTransform.Initial,
                "lowercase" => CaptionFontConfigTextTransform.Lowercase,
                "uppercase" => CaptionFontConfigTextTransform.Uppercase,
                _ => null,
            };
        }
    }
}