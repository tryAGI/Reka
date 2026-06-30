
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToVideoModelId
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
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        Veo31Fast,
        /// <summary>
        /// 
        /// </summary>
        Wan22Plus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToVideoModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToVideoModelId value)
        {
            return value switch
            {
                TextToVideoModelId.Happyhorse10 => "happyhorse-1.0",
                TextToVideoModelId.KlingV34k => "kling-v3-4k",
                TextToVideoModelId.KlingV3Pro => "kling-v3-pro",
                TextToVideoModelId.KlingV3ProAudio => "kling-v3-pro-audio",
                TextToVideoModelId.KlingV3Std => "kling-v3-std",
                TextToVideoModelId.KlingV3StdAudio => "kling-v3-std-audio",
                TextToVideoModelId.Ltx23Fast => "ltx-2-3-fast",
                TextToVideoModelId.Ltx23Pro => "ltx-2-3-pro",
                TextToVideoModelId.Seedance20Fast => "seedance-2.0-fast",
                TextToVideoModelId.Seedance20Pro => "seedance-2.0-pro",
                TextToVideoModelId.Veo31 => "veo-3.1",
                TextToVideoModelId.Veo31Fast => "veo-3.1-fast",
                TextToVideoModelId.Wan22Plus => "wan2.2-plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToVideoModelId? ToEnum(string value)
        {
            return value switch
            {
                "happyhorse-1.0" => TextToVideoModelId.Happyhorse10,
                "kling-v3-4k" => TextToVideoModelId.KlingV34k,
                "kling-v3-pro" => TextToVideoModelId.KlingV3Pro,
                "kling-v3-pro-audio" => TextToVideoModelId.KlingV3ProAudio,
                "kling-v3-std" => TextToVideoModelId.KlingV3Std,
                "kling-v3-std-audio" => TextToVideoModelId.KlingV3StdAudio,
                "ltx-2-3-fast" => TextToVideoModelId.Ltx23Fast,
                "ltx-2-3-pro" => TextToVideoModelId.Ltx23Pro,
                "seedance-2.0-fast" => TextToVideoModelId.Seedance20Fast,
                "seedance-2.0-pro" => TextToVideoModelId.Seedance20Pro,
                "veo-3.1" => TextToVideoModelId.Veo31,
                "veo-3.1-fast" => TextToVideoModelId.Veo31Fast,
                "wan2.2-plus" => TextToVideoModelId.Wan22Plus,
                _ => null,
            };
        }
    }
}