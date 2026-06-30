
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionFontConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_font_size")]
        public double? DesiredFontSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_transform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigTextTransform?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigTextTransform?, object>? TextTransform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlight_color")]
        public string? HighlightColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_color")]
        public string? StrokeColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigPosition?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigPosition?, object>? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_family")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigFontFamily?, object>))]
        public global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigFontFamily?, object>? FontFamily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionFontConfig" /> class.
        /// </summary>
        /// <param name="desiredFontSize"></param>
        /// <param name="textTransform"></param>
        /// <param name="textColor"></param>
        /// <param name="highlightColor"></param>
        /// <param name="strokeColor"></param>
        /// <param name="position"></param>
        /// <param name="fontFamily"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionFontConfig(
            double? desiredFontSize,
            global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigTextTransform?, object>? textTransform,
            string? textColor,
            string? highlightColor,
            string? strokeColor,
            global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigPosition?, object>? position,
            global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigFontFamily?, object>? fontFamily)
        {
            this.DesiredFontSize = desiredFontSize;
            this.TextTransform = textTransform;
            this.TextColor = textColor;
            this.HighlightColor = highlightColor;
            this.StrokeColor = strokeColor;
            this.Position = position;
            this.FontFamily = fontFamily;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionFontConfig" /> class.
        /// </summary>
        public CaptionFontConfig()
        {
        }

    }
}