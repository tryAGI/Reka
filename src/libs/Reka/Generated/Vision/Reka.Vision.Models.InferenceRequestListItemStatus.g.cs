
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum InferenceRequestListItemStatus
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
    public static class InferenceRequestListItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InferenceRequestListItemStatus value)
        {
            return value switch
            {
                InferenceRequestListItemStatus.Cancelled => "CANCELLED",
                InferenceRequestListItemStatus.Completed => "COMPLETED",
                InferenceRequestListItemStatus.Failed => "FAILED",
                InferenceRequestListItemStatus.InProgress => "IN_PROGRESS",
                InferenceRequestListItemStatus.InQueue => "IN_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InferenceRequestListItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => InferenceRequestListItemStatus.Cancelled,
                "COMPLETED" => InferenceRequestListItemStatus.Completed,
                "FAILED" => InferenceRequestListItemStatus.Failed,
                "IN_PROGRESS" => InferenceRequestListItemStatus.InProgress,
                "IN_QUEUE" => InferenceRequestListItemStatus.InQueue,
                _ => null,
            };
        }
    }
}