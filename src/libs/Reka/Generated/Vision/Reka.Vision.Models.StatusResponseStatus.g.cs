
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        InQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseStatus value)
        {
            return value switch
            {
                StatusResponseStatus.Cancelled => "CANCELLED",
                StatusResponseStatus.Completed => "COMPLETED",
                StatusResponseStatus.Failed => "FAILED",
                StatusResponseStatus.InProgress => "IN_PROGRESS",
                StatusResponseStatus.InQueue => "IN_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => StatusResponseStatus.Cancelled,
                "COMPLETED" => StatusResponseStatus.Completed,
                "FAILED" => StatusResponseStatus.Failed,
                "IN_PROGRESS" => StatusResponseStatus.InProgress,
                "IN_QUEUE" => StatusResponseStatus.InQueue,
                _ => null,
            };
        }
    }
}