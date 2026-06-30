
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResultResponseStatus
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
    public static class ResultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResultResponseStatus value)
        {
            return value switch
            {
                ResultResponseStatus.Cancelled => "CANCELLED",
                ResultResponseStatus.Completed => "COMPLETED",
                ResultResponseStatus.Failed => "FAILED",
                ResultResponseStatus.InProgress => "IN_PROGRESS",
                ResultResponseStatus.InQueue => "IN_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ResultResponseStatus.Cancelled,
                "COMPLETED" => ResultResponseStatus.Completed,
                "FAILED" => ResultResponseStatus.Failed,
                "IN_PROGRESS" => ResultResponseStatus.InProgress,
                "IN_QUEUE" => ResultResponseStatus.InQueue,
                _ => null,
            };
        }
    }
}