
#nullable enable

namespace Reka
{
    /// <summary>
    /// Target language for translation. When omitted, only transcription is performed.
    /// </summary>
    public enum TranscribeOrTranslateRequestTargetLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        Korean,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        German,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscribeOrTranslateRequestTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeOrTranslateRequestTargetLanguage value)
        {
            return value switch
            {
                TranscribeOrTranslateRequestTargetLanguage.French => "french",
                TranscribeOrTranslateRequestTargetLanguage.Spanish => "spanish",
                TranscribeOrTranslateRequestTargetLanguage.Japanese => "japanese",
                TranscribeOrTranslateRequestTargetLanguage.Chinese => "chinese",
                TranscribeOrTranslateRequestTargetLanguage.Korean => "korean",
                TranscribeOrTranslateRequestTargetLanguage.Italian => "italian",
                TranscribeOrTranslateRequestTargetLanguage.Portuguese => "portuguese",
                TranscribeOrTranslateRequestTargetLanguage.German => "german",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeOrTranslateRequestTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "french" => TranscribeOrTranslateRequestTargetLanguage.French,
                "spanish" => TranscribeOrTranslateRequestTargetLanguage.Spanish,
                "japanese" => TranscribeOrTranslateRequestTargetLanguage.Japanese,
                "chinese" => TranscribeOrTranslateRequestTargetLanguage.Chinese,
                "korean" => TranscribeOrTranslateRequestTargetLanguage.Korean,
                "italian" => TranscribeOrTranslateRequestTargetLanguage.Italian,
                "portuguese" => TranscribeOrTranslateRequestTargetLanguage.Portuguese,
                "german" => TranscribeOrTranslateRequestTargetLanguage.German,
                _ => null,
            };
        }
    }
}