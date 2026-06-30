
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Named relevance thresholds.
    /// </summary>
    public enum ThresholdLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThresholdLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThresholdLevel value)
        {
            return value switch
            {
                ThresholdLevel.High => "high",
                ThresholdLevel.Low => "low",
                ThresholdLevel.Medium => "medium",
                ThresholdLevel.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThresholdLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => ThresholdLevel.High,
                "low" => ThresholdLevel.Low,
                "medium" => ThresholdLevel.Medium,
                "none" => ThresholdLevel.None,
                _ => null,
            };
        }
    }
}