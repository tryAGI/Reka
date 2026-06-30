
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptTriggerRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_config")]
        public global::Reka.Vision.ChunkingConfigInput? ChunkingConfig { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downsample_video")]
        public bool? DownsampleVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTriggerRequest" /> class.
        /// </summary>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="chunkingConfig"></param>
        /// <param name="downsampleVideo">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTriggerRequest(
            bool? force,
            global::Reka.Vision.ChunkingConfigInput? chunkingConfig,
            bool? downsampleVideo)
        {
            this.Force = force;
            this.ChunkingConfig = chunkingConfig;
            this.DownsampleVideo = downsampleVideo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTriggerRequest" /> class.
        /// </summary>
        public TranscriptTriggerRequest()
        {
        }

    }
}