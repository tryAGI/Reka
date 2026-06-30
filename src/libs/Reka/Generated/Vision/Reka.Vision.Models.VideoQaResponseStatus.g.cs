
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: pending
    /// </summary>
    public enum VideoQaResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoQaResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoQaResponseStatus value)
        {
            return value switch
            {
                VideoQaResponseStatus.Error => "error",
                VideoQaResponseStatus.Indexing => "indexing",
                VideoQaResponseStatus.Pending => "pending",
                VideoQaResponseStatus.Streaming => "streaming",
                VideoQaResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoQaResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoQaResponseStatus.Error,
                "indexing" => VideoQaResponseStatus.Indexing,
                "pending" => VideoQaResponseStatus.Pending,
                "streaming" => VideoQaResponseStatus.Streaming,
                "success" => VideoQaResponseStatus.Success,
                _ => null,
            };
        }
    }
}