
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Default Value: mp3_44100_128
    /// </summary>
    public enum TextToSpeechInputOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp32205032,
        /// <summary>
        /// 
        /// </summary>
        Mp344100128,
        /// <summary>
        /// 
        /// </summary>
        Mp34410064,
        /// <summary>
        /// 
        /// </summary>
        Opus48000128,
        /// <summary>
        /// 
        /// </summary>
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        Wav44100,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechInputOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechInputOutputFormat value)
        {
            return value switch
            {
                TextToSpeechInputOutputFormat.Mp32205032 => "mp3_22050_32",
                TextToSpeechInputOutputFormat.Mp344100128 => "mp3_44100_128",
                TextToSpeechInputOutputFormat.Mp34410064 => "mp3_44100_64",
                TextToSpeechInputOutputFormat.Opus48000128 => "opus_48000_128",
                TextToSpeechInputOutputFormat.Pcm44100 => "pcm_44100",
                TextToSpeechInputOutputFormat.Wav44100 => "wav_44100",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechInputOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3_22050_32" => TextToSpeechInputOutputFormat.Mp32205032,
                "mp3_44100_128" => TextToSpeechInputOutputFormat.Mp344100128,
                "mp3_44100_64" => TextToSpeechInputOutputFormat.Mp34410064,
                "opus_48000_128" => TextToSpeechInputOutputFormat.Opus48000128,
                "pcm_44100" => TextToSpeechInputOutputFormat.Pcm44100,
                "wav_44100" => TextToSpeechInputOutputFormat.Wav44100,
                _ => null,
            };
        }
    }
}