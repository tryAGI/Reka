
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeatureStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeatureStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeatureStatus value)
        {
            return value switch
            {
                FeatureStatus.Blocked => "blocked",
                FeatureStatus.Failed => "failed",
                FeatureStatus.None => "none",
                FeatureStatus.Pending => "pending",
                FeatureStatus.Processing => "processing",
                FeatureStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeatureStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => FeatureStatus.Blocked,
                "failed" => FeatureStatus.Failed,
                "none" => FeatureStatus.None,
                "pending" => FeatureStatus.Pending,
                "processing" => FeatureStatus.Processing,
                "ready" => FeatureStatus.Ready,
                _ => null,
            };
        }
    }
}