
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Reframing layout choice for non-16:9 aspect ratios.<br/>
    /// AI: bbox-driven cover crop (zoom into faces/text). FIT: full source frame<br/>
    /// scaled into the target with letterbox/pillarbox bars.
    /// </summary>
    public enum ClipLayout
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Fit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipLayout value)
        {
            return value switch
            {
                ClipLayout.Ai => "ai",
                ClipLayout.Fit => "fit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipLayout? ToEnum(string value)
        {
            return value switch
            {
                "ai" => ClipLayout.Ai,
                "fit" => ClipLayout.Fit,
                _ => null,
            };
        }
    }
}