
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoIndexingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Indexed,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoIndexingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoIndexingStatus value)
        {
            return value switch
            {
                VideoIndexingStatus.Failed => "failed",
                VideoIndexingStatus.Indexed => "indexed",
                VideoIndexingStatus.Indexing => "indexing",
                VideoIndexingStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoIndexingStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => VideoIndexingStatus.Failed,
                "indexed" => VideoIndexingStatus.Indexed,
                "indexing" => VideoIndexingStatus.Indexing,
                "pending" => VideoIndexingStatus.Pending,
                _ => null,
            };
        }
    }
}