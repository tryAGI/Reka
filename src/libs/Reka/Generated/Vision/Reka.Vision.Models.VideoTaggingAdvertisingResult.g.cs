
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTaggingAdvertisingResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Violence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Violence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Profanity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Profanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("AdultContent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AdultContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Drugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Drugs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Alcohol")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Alcohol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Gambling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Gambling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Political")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Political { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ExpectedCTR")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpectedCTR { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ViralityScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ViralityScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Keyword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MoodTone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MoodTone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTaggingAdvertisingResult" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="violence"></param>
        /// <param name="profanity"></param>
        /// <param name="adultContent"></param>
        /// <param name="drugs"></param>
        /// <param name="alcohol"></param>
        /// <param name="gambling"></param>
        /// <param name="political"></param>
        /// <param name="expectedCTR"></param>
        /// <param name="viralityScore"></param>
        /// <param name="keyword"></param>
        /// <param name="moodTone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTaggingAdvertisingResult(
            string description,
            bool violence,
            bool profanity,
            bool adultContent,
            bool drugs,
            bool alcohol,
            bool gambling,
            bool political,
            double expectedCTR,
            double viralityScore,
            global::System.Collections.Generic.IList<string> keyword,
            global::System.Collections.Generic.IList<string> moodTone)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Violence = violence;
            this.Profanity = profanity;
            this.AdultContent = adultContent;
            this.Drugs = drugs;
            this.Alcohol = alcohol;
            this.Gambling = gambling;
            this.Political = political;
            this.ExpectedCTR = expectedCTR;
            this.ViralityScore = viralityScore;
            this.Keyword = keyword ?? throw new global::System.ArgumentNullException(nameof(keyword));
            this.MoodTone = moodTone ?? throw new global::System.ArgumentNullException(nameof(moodTone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTaggingAdvertisingResult" /> class.
        /// </summary>
        public VideoTaggingAdvertisingResult()
        {
        }

    }
}