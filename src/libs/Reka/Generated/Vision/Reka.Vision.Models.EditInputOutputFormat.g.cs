
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: png
    /// </summary>
    public enum EditInputOutputFormat
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
    public static class EditInputOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditInputOutputFormat value)
        {
            return value switch
            {
                EditInputOutputFormat.Jpeg => "jpeg",
                EditInputOutputFormat.Png => "png",
                EditInputOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditInputOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => EditInputOutputFormat.Jpeg,
                "png" => EditInputOutputFormat.Png,
                "webp" => EditInputOutputFormat.Webp,
                _ => null,
            };
        }
    }
}