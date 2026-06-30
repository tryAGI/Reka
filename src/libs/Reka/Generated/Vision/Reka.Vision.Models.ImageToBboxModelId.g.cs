
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToBboxModelId
    {
        /// <summary>
        /// 
        /// </summary>
        Sam3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToBboxModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToBboxModelId value)
        {
            return value switch
            {
                ImageToBboxModelId.Sam3 => "sam3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToBboxModelId? ToEnum(string value)
        {
            return value switch
            {
                "sam3" => ImageToBboxModelId.Sam3,
                _ => null,
            };
        }
    }
}