
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: png
    /// </summary>
    public enum TextToImageInputOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageInputOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageInputOutputFormat value)
        {
            return value switch
            {
                TextToImageInputOutputFormat.Jpeg => "jpeg",
                TextToImageInputOutputFormat.Png => "png",
                TextToImageInputOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageInputOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => TextToImageInputOutputFormat.Jpeg,
                "png" => TextToImageInputOutputFormat.Png,
                "webp" => TextToImageInputOutputFormat.Webp,
                _ => null,
            };
        }
    }
}