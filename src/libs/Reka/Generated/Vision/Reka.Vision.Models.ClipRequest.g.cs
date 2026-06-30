
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Request model for Clip API
    /// </summary>
    public sealed partial class ClipRequest
    {
        /// <summary>
        /// List of video URLs to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VideoUrls { get; set; }

        /// <summary>
        /// Prompt for video generation<br/>
        /// Default Value: Create an engaging short video highlighting the best moments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Grouped generation configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::Reka.Vision.ClipGenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Grouped rendering configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_config")]
        public global::Reka.Vision.ClipRenderingConfig? RenderingConfig { get; set; }

        /// <summary>
        /// Whether to stream the generation process<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipRequest" /> class.
        /// </summary>
        /// <param name="videoUrls">
        /// List of video URLs to process
        /// </param>
        /// <param name="prompt">
        /// Prompt for video generation<br/>
        /// Default Value: Create an engaging short video highlighting the best moments
        /// </param>
        /// <param name="generationConfig">
        /// Grouped generation configuration
        /// </param>
        /// <param name="renderingConfig">
        /// Grouped rendering configuration
        /// </param>
        /// <param name="stream">
        /// Whether to stream the generation process<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipRequest(
            global::System.Collections.Generic.IList<string> videoUrls,
            string? prompt,
            global::Reka.Vision.ClipGenerationConfig? generationConfig,
            global::Reka.Vision.ClipRenderingConfig? renderingConfig,
            bool? stream)
        {
            this.VideoUrls = videoUrls ?? throw new global::System.ArgumentNullException(nameof(videoUrls));
            this.Prompt = prompt;
            this.GenerationConfig = generationConfig;
            this.RenderingConfig = renderingConfig;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipRequest" /> class.
        /// </summary>
        public ClipRequest()
        {
        }

    }
}