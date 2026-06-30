
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoUploadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        Uploading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoUploadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoUploadStatus value)
        {
            return value switch
            {
                VideoUploadStatus.Failed => "failed",
                VideoUploadStatus.Uploaded => "uploaded",
                VideoUploadStatus.Uploading => "uploading",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoUploadStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => VideoUploadStatus.Failed,
                "uploaded" => VideoUploadStatus.Uploaded,
                "uploading" => VideoUploadStatus.Uploading,
                _ => null,
            };
        }
    }
}