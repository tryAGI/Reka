
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Response-side view of the generation config.<br/>
    /// Request input caps ``num_generations`` at 1-3, but the auto pipeline<br/>
    /// resolves it from video duration up to 12 (and transiently 0 before<br/>
    /// resolution completes). Widening the bound here keeps the response<br/>
    /// OpenAPI schema honest so strict clients don't reject a valid 0-12 value.
    /// </summary>
    public sealed partial class ClipGenerationConfigResult
    {
        /// <summary>
        /// Template type for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoGenerationTemplateJsonConverter))]
        public global::Reka.Vision.VideoGenerationTemplate? Template { get; set; }

        /// <summary>
        /// Resolved number of clips. 1-12 once auto-resolution completes; 0 while an auto request is still pending resolution.
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
        /// Initializes a new instance of the <see cref="ClipGenerationConfigResult" /> class.
        /// </summary>
        /// <param name="template">
        /// Template type for generation
        /// </param>
        /// <param name="numGenerations">
        /// Resolved number of clips. 1-12 once auto-resolution completes; 0 while an auto request is still pending resolution.
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
        public ClipGenerationConfigResult(
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
        /// Initializes a new instance of the <see cref="ClipGenerationConfigResult" /> class.
        /// </summary>
        public ClipGenerationConfigResult()
        {
        }

    }
}