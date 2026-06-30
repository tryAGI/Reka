
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Generation settings for the Clip API
    /// </summary>
    public sealed partial class ClipGenerationConfig
    {
        /// <summary>
        /// Template type for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoGenerationTemplateJsonConverter))]
        public global::Reka.Vision.VideoGenerationTemplate? Template { get; set; }

        /// <summary>
        /// Number of clips to generate. When provided, must be 1-3. Omit to auto-derive the count from the effective video duration: 3 for videos up to 45 minutes, +1 per additional 15 minutes, capped at 12. The resolved count is returned in the response once auto-resolution completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_generations")]
        public int? NumGenerations { get; set; }

        /// <summary>
        /// Minimum duration in seconds<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_seconds")]
        public int? MinDurationSeconds { get; set; }

        /// <summary>
        /// Maximum duration in seconds<br/>
        /// Default Value: 90
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Start time in seconds for source video download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_start_time")]
        public int? SourceStartTime { get; set; }

        /// <summary>
        /// End time in seconds for source video download.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_end_time")]
        public int? SourceEndTime { get; set; }

        /// <summary>
        /// Optional locale to auto-generate translated subtitles after generation completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_subtitles_target_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.SubtitleTranslationLocale?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.SubtitleTranslationLocale?, object>? TranslatedSubtitlesTargetLanguage { get; set; }

        /// <summary>
        /// Max character length of a translated subtitle group before splitting on word boundaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_subtitles_group_length")]
        public int? TranslatedSubtitlesGroupLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipGenerationConfig" /> class.
        /// </summary>
        /// <param name="template">
        /// Template type for generation
        /// </param>
        /// <param name="numGenerations">
        /// Number of clips to generate. When provided, must be 1-3. Omit to auto-derive the count from the effective video duration: 3 for videos up to 45 minutes, +1 per additional 15 minutes, capped at 12. The resolved count is returned in the response once auto-resolution completes.
        /// </param>
        /// <param name="minDurationSeconds">
        /// Minimum duration in seconds<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxDurationSeconds">
        /// Maximum duration in seconds<br/>
        /// Default Value: 90
        /// </param>
        /// <param name="sourceStartTime">
        /// Start time in seconds for source video download.
        /// </param>
        /// <param name="sourceEndTime">
        /// End time in seconds for source video download.
        /// </param>
        /// <param name="translatedSubtitlesTargetLanguage">
        /// Optional locale to auto-generate translated subtitles after generation completes.
        /// </param>
        /// <param name="translatedSubtitlesGroupLength">
        /// Max character length of a translated subtitle group before splitting on word boundaries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipGenerationConfig(
            global::Reka.Vision.VideoGenerationTemplate? template,
            int? numGenerations,
            int? minDurationSeconds,
            int? maxDurationSeconds,
            int? sourceStartTime,
            int? sourceEndTime,
            global::Reka.Vision.OneOf<global::Reka.Vision.SubtitleTranslationLocale?, object>? translatedSubtitlesTargetLanguage,
            int? translatedSubtitlesGroupLength)
        {
            this.Template = template;
            this.NumGenerations = numGenerations;
            this.MinDurationSeconds = minDurationSeconds;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.SourceStartTime = sourceStartTime;
            this.SourceEndTime = sourceEndTime;
            this.TranslatedSubtitlesTargetLanguage = translatedSubtitlesTargetLanguage;
            this.TranslatedSubtitlesGroupLength = translatedSubtitlesGroupLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipGenerationConfig" /> class.
        /// </summary>
        public ClipGenerationConfig()
        {
        }

    }
}