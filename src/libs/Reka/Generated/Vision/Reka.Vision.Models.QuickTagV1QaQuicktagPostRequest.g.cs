
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuickTagV1QaQuicktagPostRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Videoname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickTagV1QaQuicktagPostRequest" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoname"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuickTagV1QaQuicktagPostRequest(
            byte[] video,
            string videoname)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.Videoname = videoname ?? throw new global::System.ArgumentNullException(nameof(videoname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickTagV1QaQuicktagPostRequest" /> class.
        /// </summary>
        public QuickTagV1QaQuicktagPostRequest()
        {
        }

    }
}