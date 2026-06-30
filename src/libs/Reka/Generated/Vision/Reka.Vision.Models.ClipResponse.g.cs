
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Response model for Clip API
    /// </summary>
    public sealed partial class ClipResponse
    {
        /// <summary>
        /// Unique identifier for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Current status of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Generation configuration used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.ClipGenerationConfigResult, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.ClipGenerationConfigResult, object>? GenerationConfig { get; set; }

        /// <summary>
        /// Rendering configuration used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.ClipRenderingConfig, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.ClipRenderingConfig, object>? RenderingConfig { get; set; }

        /// <summary>
        /// List of input video URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_urls")]
        public global::System.Collections.Generic.IList<string>? VideoUrls { get; set; }

        /// <summary>
        /// Prompt used for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Generated reel outputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::Reka.Vision.ClipOutput>? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generation
        /// </param>
        /// <param name="status">
        /// Current status of the generation
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="generationConfig">
        /// Generation configuration used
        /// </param>
        /// <param name="renderingConfig">
        /// Rendering configuration used
        /// </param>
        /// <param name="videoUrls">
        /// List of input video URLs
        /// </param>
        /// <param name="prompt">
        /// Prompt used for generation
        /// </param>
        /// <param name="output">
        /// Generated reel outputs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipResponse(
            string id,
            string status,
            string? createdAt,
            string? updatedAt,
            global::Reka.Vision.OneOf<global::Reka.Vision.ClipGenerationConfigResult, object>? generationConfig,
            global::Reka.Vision.OneOf<global::Reka.Vision.ClipRenderingConfig, object>? renderingConfig,
            global::System.Collections.Generic.IList<string>? videoUrls,
            string? prompt,
            global::System.Collections.Generic.IList<global::Reka.Vision.ClipOutput>? output)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.GenerationConfig = generationConfig;
            this.RenderingConfig = renderingConfig;
            this.VideoUrls = videoUrls;
            this.Prompt = prompt;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipResponse" /> class.
        /// </summary>
        public ClipResponse()
        {
        }

    }
}