
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToImageModelId
    {
        /// <summary>
        /// 
        /// </summary>
        Flux2,
        /// <summary>
        /// 
        /// </summary>
        Flux2Max,
        /// <summary>
        /// 
        /// </summary>
        Flux2Pro,
        /// <summary>
        /// 
        /// </summary>
        GptImage2,
        /// <summary>
        /// 
        /// </summary>
        Ideogram4,
        /// <summary>
        /// 
        /// </summary>
        Ideogram4Quality,
        /// <summary>
        /// 
        /// </summary>
        Ideogram4Turbo,
        /// <summary>
        /// 
        /// </summary>
        NanoBanana2,
        /// <summary>
        /// 
        /// </summary>
        QwenImage2512,
        /// <summary>
        /// 
        /// </summary>
        QwenImageMaxPreview,
        /// <summary>
        /// 
        /// </summary>
        Seedream4,
        /// <summary>
        /// 
        /// </summary>
        Seedream45,
        /// <summary>
        /// 
        /// </summary>
        Uni1,
        /// <summary>
        /// 
        /// </summary>
        Uni1Max,
        /// <summary>
        /// 
        /// </summary>
        Wan27Fast,
        /// <summary>
        /// 
        /// </summary>
        Wan27Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageModelId value)
        {
            return value switch
            {
                TextToImageModelId.Flux2 => "flux-2",
                TextToImageModelId.Flux2Max => "flux-2-max",
                TextToImageModelId.Flux2Pro => "flux-2-pro",
                TextToImageModelId.GptImage2 => "gpt-image-2",
                TextToImageModelId.Ideogram4 => "ideogram-4",
                TextToImageModelId.Ideogram4Quality => "ideogram-4-quality",
                TextToImageModelId.Ideogram4Turbo => "ideogram-4-turbo",
                TextToImageModelId.NanoBanana2 => "nano-banana-2",
                TextToImageModelId.QwenImage2512 => "qwen-image-2512",
                TextToImageModelId.QwenImageMaxPreview => "qwen-image-max-preview",
                TextToImageModelId.Seedream4 => "seedream-4",
                TextToImageModelId.Seedream45 => "seedream-4.5",
                TextToImageModelId.Uni1 => "uni-1",
                TextToImageModelId.Uni1Max => "uni-1-max",
                TextToImageModelId.Wan27Fast => "wan2.7-fast",
                TextToImageModelId.Wan27Pro => "wan2.7-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageModelId? ToEnum(string value)
        {
            return value switch
            {
                "flux-2" => TextToImageModelId.Flux2,
                "flux-2-max" => TextToImageModelId.Flux2Max,
                "flux-2-pro" => TextToImageModelId.Flux2Pro,
                "gpt-image-2" => TextToImageModelId.GptImage2,
                "ideogram-4" => TextToImageModelId.Ideogram4,
                "ideogram-4-quality" => TextToImageModelId.Ideogram4Quality,
                "ideogram-4-turbo" => TextToImageModelId.Ideogram4Turbo,
                "nano-banana-2" => TextToImageModelId.NanoBanana2,
                "qwen-image-2512" => TextToImageModelId.QwenImage2512,
                "qwen-image-max-preview" => TextToImageModelId.QwenImageMaxPreview,
                "seedream-4" => TextToImageModelId.Seedream4,
                "seedream-4.5" => TextToImageModelId.Seedream45,
                "uni-1" => TextToImageModelId.Uni1,
                "uni-1-max" => TextToImageModelId.Uni1Max,
                "wan2.7-fast" => TextToImageModelId.Wan27Fast,
                "wan2.7-pro" => TextToImageModelId.Wan27Pro,
                _ => null,
            };
        }
    }
}