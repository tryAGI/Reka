
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Individual reel output model for Clip API
    /// </summary>
    public sealed partial class ClipOutput
    {
        /// <summary>
        /// Title of the generated reel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// URL of the generated video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Presigned S3 URL for the generated video (for Lambda rendering)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_s3_video_url")]
        public string? SignedS3VideoUrl { get; set; }

        /// <summary>
        /// Caption for the reel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Caption { get; set; }

        /// <summary>
        /// List of hashtags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashtags")]
        public global::System.Collections.Generic.IList<string>? Hashtags { get; set; }

        /// <summary>
        /// AI rating score (0-100)<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_score")]
        public int? AiScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipOutput" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the generated reel
        /// </param>
        /// <param name="caption">
        /// Caption for the reel
        /// </param>
        /// <param name="videoUrl">
        /// URL of the generated video
        /// </param>
        /// <param name="signedS3VideoUrl">
        /// Presigned S3 URL for the generated video (for Lambda rendering)
        /// </param>
        /// <param name="hashtags">
        /// List of hashtags
        /// </param>
        /// <param name="aiScore">
        /// AI rating score (0-100)<br/>
        /// Default Value: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipOutput(
            string title,
            string caption,
            string? videoUrl,
            string? signedS3VideoUrl,
            global::System.Collections.Generic.IList<string>? hashtags,
            int? aiScore)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.VideoUrl = videoUrl;
            this.SignedS3VideoUrl = signedS3VideoUrl;
            this.Caption = caption ?? throw new global::System.ArgumentNullException(nameof(caption));
            this.Hashtags = hashtags;
            this.AiScore = aiScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipOutput" /> class.
        /// </summary>
        public ClipOutput()
        {
        }

    }
}