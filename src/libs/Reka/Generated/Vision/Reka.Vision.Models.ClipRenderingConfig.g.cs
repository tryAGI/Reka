
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Rendering settings for the Clip API
    /// </summary>
    public sealed partial class ClipRenderingConfig
    {
        /// <summary>
        /// Whether to display reka watermark<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_watermark")]
        public bool? ShowWatermark { get; set; }

        /// <summary>
        /// Whether to enable subtitles<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// Aspect ratio for the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.AspectRatioJsonConverter))]
        public global::Reka.Vision.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Target resolution for the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.VideoResolutionJsonConverter))]
        public global::Reka.Vision.VideoResolution? Resolution { get; set; }

        /// <summary>
        /// Caption styling overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfig, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfig, object>? CaptionStyle { get; set; }

        /// <summary>
        /// How to fit the source video into the target aspect_ratio. 'ai' (default) reframes the source to fill the target, keeping the most relevant content in view. 'fit' preserves the entire source frame inside the target, adding bars on the unfilled sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.ClipLayoutJsonConverter))]
        public global::Reka.Vision.ClipLayout? Layout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipRenderingConfig" /> class.
        /// </summary>
        /// <param name="showWatermark">
        /// Whether to display reka watermark<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subtitles">
        /// Whether to enable subtitles<br/>
        /// Default Value: true
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio for the video
        /// </param>
        /// <param name="resolution">
        /// Target resolution for the video
        /// </param>
        /// <param name="captionStyle">
        /// Caption styling overrides
        /// </param>
        /// <param name="layout">
        /// How to fit the source video into the target aspect_ratio. 'ai' (default) reframes the source to fill the target, keeping the most relevant content in view. 'fit' preserves the entire source frame inside the target, adding bars on the unfilled sides.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipRenderingConfig(
            bool? showWatermark,
            bool? subtitles,
            global::Reka.Vision.AspectRatio? aspectRatio,
            global::Reka.Vision.VideoResolution? resolution,
            global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfig, object>? captionStyle,
            global::Reka.Vision.ClipLayout? layout)
        {
            this.ShowWatermark = showWatermark;
            this.Subtitles = subtitles;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.CaptionStyle = captionStyle;
            this.Layout = layout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipRenderingConfig" /> class.
        /// </summary>
        public ClipRenderingConfig()
        {
        }

    }
}