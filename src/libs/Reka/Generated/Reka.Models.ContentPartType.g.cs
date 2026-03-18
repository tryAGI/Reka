
#nullable enable

namespace Reka
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    public enum ContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        PdfUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartType value)
        {
            return value switch
            {
                ContentPartType.Text => "text",
                ContentPartType.ImageUrl => "image_url",
                ContentPartType.VideoUrl => "video_url",
                ContentPartType.AudioUrl => "audio_url",
                ContentPartType.PdfUrl => "pdf_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ContentPartType.Text,
                "image_url" => ContentPartType.ImageUrl,
                "video_url" => ContentPartType.VideoUrl,
                "audio_url" => ContentPartType.AudioUrl,
                "pdf_url" => ContentPartType.PdfUrl,
                _ => null,
            };
        }
    }
}