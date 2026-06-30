
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToVideoInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_b64")]
        public string? ImageB64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_frame_image_url")]
        public string? LastFrameImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_frame_image_b64")]
        public string? LastFrameImageB64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.ImageToVideoInputAspectRatioJsonConverter))]
        public global::Reka.Vision.ImageToVideoInputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoInput" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageUrl"></param>
        /// <param name="imageB64"></param>
        /// <param name="lastFrameImageUrl"></param>
        /// <param name="lastFrameImageB64"></param>
        /// <param name="durationSeconds">
        /// Default Value: 5
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="seed"></param>
        /// <param name="audio">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoInput(
            string prompt,
            string? imageUrl,
            string? imageB64,
            string? lastFrameImageUrl,
            string? lastFrameImageB64,
            int? durationSeconds,
            global::Reka.Vision.ImageToVideoInputAspectRatio? aspectRatio,
            int? seed,
            bool? audio)
        {
            this.ImageUrl = imageUrl;
            this.ImageB64 = imageB64;
            this.LastFrameImageUrl = lastFrameImageUrl;
            this.LastFrameImageB64 = lastFrameImageB64;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.DurationSeconds = durationSeconds;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoInput" /> class.
        /// </summary>
        public ImageToVideoInput()
        {
        }

    }
}