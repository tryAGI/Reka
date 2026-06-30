
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Search mode: 'vision' for vision-only search, 'joined' for hybrid search<br/>
    /// Default Value: vision
    /// </summary>
    public enum ImageSearchRequestSearchMode
    {
        /// <summary>
        /// 'vision' for vision-only search, 'joined' for hybrid search
        /// </summary>
        Joined,
        /// <summary>
        /// 'vision' for vision-only search, 'joined' for hybrid search
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSearchRequestSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSearchRequestSearchMode value)
        {
            return value switch
            {
                ImageSearchRequestSearchMode.Joined => "joined",
                ImageSearchRequestSearchMode.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSearchRequestSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "joined" => ImageSearchRequestSearchMode.Joined,
                "vision" => ImageSearchRequestSearchMode.Vision,
                _ => null,
            };
        }
    }
}