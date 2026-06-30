
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageToVideoModelId
    {
        /// <summary>
        /// 
        /// </summary>
        Happyhorse10,
        /// <summary>
        /// 
        /// </summary>
        KlingV34k,
        /// <summary>
        /// 
        /// </summary>
        KlingV3Pro,
        /// <summary>
        /// 
        /// </summary>
        KlingV3ProAudio,
        /// <summary>
        /// 
        /// </summary>
        KlingV3Std,
        /// <summary>
        /// 
        /// </summary>
        KlingV3StdAudio,
        /// <summary>
        /// 
        /// </summary>
        Ltx23Fast,
        /// <summary>
        /// 
        /// </summary>
        Ltx23Pro,
        /// <summary>
        /// 
        /// </summary>
        Seedance20Fast,
        /// <summary>
        /// 
        /// </summary>
        Seedance20Pro,
        /// <summary>
        /// 
        /// </summary>
        Wan22Flash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoModelId value)
        {
            return value switch
            {
                ImageToVideoModelId.Happyhorse10 => "happyhorse-1.0",
                ImageToVideoModelId.KlingV34k => "kling-v3-4k",
                ImageToVideoModelId.KlingV3Pro => "kling-v3-pro",
                ImageToVideoModelId.KlingV3ProAudio => "kling-v3-pro-audio",
                ImageToVideoModelId.KlingV3Std => "kling-v3-std",
                ImageToVideoModelId.KlingV3StdAudio => "kling-v3-std-audio",
                ImageToVideoModelId.Ltx23Fast => "ltx-2-3-fast",
                ImageToVideoModelId.Ltx23Pro => "ltx-2-3-pro",
                ImageToVideoModelId.Seedance20Fast => "seedance-2.0-fast",
                ImageToVideoModelId.Seedance20Pro => "seedance-2.0-pro",
                ImageToVideoModelId.Wan22Flash => "wan2.2-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoModelId? ToEnum(string value)
        {
            return value switch
            {
                "happyhorse-1.0" => ImageToVideoModelId.Happyhorse10,
                "kling-v3-4k" => ImageToVideoModelId.KlingV34k,
                "kling-v3-pro" => ImageToVideoModelId.KlingV3Pro,
                "kling-v3-pro-audio" => ImageToVideoModelId.KlingV3ProAudio,
                "kling-v3-std" => ImageToVideoModelId.KlingV3Std,
                "kling-v3-std-audio" => ImageToVideoModelId.KlingV3StdAudio,
                "ltx-2-3-fast" => ImageToVideoModelId.Ltx23Fast,
                "ltx-2-3-pro" => ImageToVideoModelId.Ltx23Pro,
                "seedance-2.0-fast" => ImageToVideoModelId.Seedance20Fast,
                "seedance-2.0-pro" => ImageToVideoModelId.Seedance20Pro,
                "wan2.2-flash" => ImageToVideoModelId.Wan22Flash,
                _ => null,
            };
        }
    }
}