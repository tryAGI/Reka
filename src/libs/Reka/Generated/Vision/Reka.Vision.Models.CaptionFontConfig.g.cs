
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
        public global::Reka.Vision.CaptionFontConfigTextTransform? TextTransform { get; set; }

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
        public global::Reka.Vision.CaptionFontConfigPosition? Position { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_family")]
        public global::Reka.Vision.CaptionFontConfigFontFamily? FontFamily { get; set; }

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
            global::Reka.Vision.CaptionFontConfigTextTransform? textTransform,
            string? textColor,
            string? highlightColor,
            string? strokeColor,
            global::Reka.Vision.CaptionFontConfigPosition? position,
            global::Reka.Vision.CaptionFontConfigFontFamily? fontFamily)
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