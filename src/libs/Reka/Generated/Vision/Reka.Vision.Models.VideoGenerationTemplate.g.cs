
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGenerationTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        CaptionOnly,
        /// <summary>
        /// 
        /// </summary>
        Compilation,
        /// <summary>
        /// 
        /// </summary>
        Moments,
        /// <summary>
        /// 
        /// </summary>
        Trailer,
        /// <summary>
        /// 
        /// </summary>
        Voiceover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationTemplate value)
        {
            return value switch
            {
                VideoGenerationTemplate.CaptionOnly => "caption_only",
                VideoGenerationTemplate.Compilation => "compilation",
                VideoGenerationTemplate.Moments => "moments",
                VideoGenerationTemplate.Trailer => "trailer",
                VideoGenerationTemplate.Voiceover => "voiceover",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationTemplate? ToEnum(string value)
        {
            return value switch
            {
                "caption_only" => VideoGenerationTemplate.CaptionOnly,
                "compilation" => VideoGenerationTemplate.Compilation,
                "moments" => VideoGenerationTemplate.Moments,
                "trailer" => VideoGenerationTemplate.Trailer,
                "voiceover" => VideoGenerationTemplate.Voiceover,
                _ => null,
            };
        }
    }
}