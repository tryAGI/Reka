
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditModelId
    {
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2,
        /// <summary>
        /// 
        /// </summary>
        Seedream4,
        /// <summary>
        /// 
        /// </summary>
        Seedream45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditModelId value)
        {
            return value switch
            {
                EditModelId.GptImage2 => "gpt-image-2",
                EditModelId.NanoBanana2 => "nano-banana-2",
                EditModelId.Seedream4 => "seedream-4",
                EditModelId.Seedream45 => "seedream-4.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditModelId? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-2" => EditModelId.GptImage2,
                "nano-banana-2" => EditModelId.NanoBanana2,
                "seedream-4" => EditModelId.Seedream4,
                "seedream-4.5" => EditModelId.Seedream45,
                _ => null,
            };
        }
    }
}