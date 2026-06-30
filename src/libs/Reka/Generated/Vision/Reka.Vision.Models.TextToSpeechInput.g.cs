
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// ElevenLabs voice id (see voice library).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// Default Value: mp3_44100_128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.TextToSpeechInputOutputFormatJsonConverter))]
        public global::Reka.Vision.TextToSpeechInputOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VoiceSettingsInput, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.VoiceSettingsInput, object>? VoiceSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechInput" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="voiceId">
        /// ElevenLabs voice id (see voice library).
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="languageCode"></param>
        /// <param name="seed"></param>
        /// <param name="voiceSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechInput(
            string text,
            string voiceId,
            global::Reka.Vision.TextToSpeechInputOutputFormat? outputFormat,
            string? languageCode,
            int? seed,
            global::Reka.Vision.OneOf<global::Reka.Vision.VoiceSettingsInput, object>? voiceSettings)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.OutputFormat = outputFormat;
            this.LanguageCode = languageCode;
            this.Seed = seed;
            this.VoiceSettings = voiceSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechInput" /> class.
        /// </summary>
        public TextToSpeechInput()
        {
        }

    }
}