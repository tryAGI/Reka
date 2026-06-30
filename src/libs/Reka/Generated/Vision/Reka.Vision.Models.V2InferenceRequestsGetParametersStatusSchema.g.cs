
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Filter by lifecycle status.
    /// </summary>
    public enum V2InferenceRequestsGetParametersStatusSchema
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
    public static class V2InferenceRequestsGetParametersStatusSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2InferenceRequestsGetParametersStatusSchema value)
        {
            return value switch
            {
                V2InferenceRequestsGetParametersStatusSchema.Cancelled => "CANCELLED",
                V2InferenceRequestsGetParametersStatusSchema.Completed => "COMPLETED",
                V2InferenceRequestsGetParametersStatusSchema.Failed => "FAILED",
                V2InferenceRequestsGetParametersStatusSchema.InProgress => "IN_PROGRESS",
                V2InferenceRequestsGetParametersStatusSchema.InQueue => "IN_QUEUE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2InferenceRequestsGetParametersStatusSchema? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => V2InferenceRequestsGetParametersStatusSchema.Cancelled,
                "COMPLETED" => V2InferenceRequestsGetParametersStatusSchema.Completed,
                "FAILED" => V2InferenceRequestsGetParametersStatusSchema.Failed,
                "IN_PROGRESS" => V2InferenceRequestsGetParametersStatusSchema.InProgress,
                "IN_QUEUE" => V2InferenceRequestsGetParametersStatusSchema.InQueue,
                _ => null,
            };
        }
    }
}