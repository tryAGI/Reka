
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubmitResponseStatus
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
    public static class SubmitResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitResponseStatus value)
        {
            return value switch
            {
                SubmitResponseStatus.Cancelled => "CANCELLED",
                SubmitResponseStatus.Completed => "COMPLETED",
                SubmitResponseStatus.Failed => "FAILED",
                SubmitResponseStatus.InProgress => "IN_PROGRESS",
                SubmitResponseStatus.InQueue => "IN_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => SubmitResponseStatus.Cancelled,
                "COMPLETED" => SubmitResponseStatus.Completed,
                "FAILED" => SubmitResponseStatus.Failed,
                "IN_PROGRESS" => SubmitResponseStatus.InProgress,
                "IN_QUEUE" => SubmitResponseStatus.InQueue,
                _ => null,
            };
        }
    }
}