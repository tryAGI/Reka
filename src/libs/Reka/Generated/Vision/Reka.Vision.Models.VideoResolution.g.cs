
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Video resolution options in pixels (height).
    /// </summary>
    public enum VideoResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080,
        /// <summary>
        /// 
        /// </summary>
        x240,
        /// <summary>
        /// 
        /// </summary>
        x360,
        /// <summary>
        /// 
        /// </summary>
        x480,
        /// <summary>
        /// 
        /// </summary>
        x720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResolution value)
        {
            return value switch
            {
                VideoResolution.x1080 => "1080",
                VideoResolution.x240 => "240",
                VideoResolution.x360 => "360",
                VideoResolution.x480 => "480",
                VideoResolution.x720 => "720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080" => VideoResolution.x1080,
                "240" => VideoResolution.x240,
                "360" => VideoResolution.x360,
                "480" => VideoResolution.x480,
                "720" => VideoResolution.x720,
                _ => null,
            };
        }
    }
}