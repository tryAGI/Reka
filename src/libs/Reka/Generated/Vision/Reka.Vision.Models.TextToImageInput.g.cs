
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToImageInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.TextToImageInputAspectRatioJsonConverter))]
        public global::Reka.Vision.TextToImageInputAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.TextToImageInputOutputFormatJsonConverter))]
        public global::Reka.Vision.TextToImageInputOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageInput" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToImageInput(
            string prompt,
            int? numImages,
            global::Reka.Vision.TextToImageInputAspectRatio? aspectRatio,
            global::Reka.Vision.TextToImageInputOutputFormat? outputFormat,
            int? seed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NumImages = numImages;
            this.AspectRatio = aspectRatio;
            this.OutputFormat = outputFormat;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToImageInput" /> class.
        /// </summary>
        public TextToImageInput()
        {
        }

    }
}