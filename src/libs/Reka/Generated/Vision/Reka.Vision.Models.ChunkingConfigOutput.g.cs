
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkingConfigOutput
    {
        /// <summary>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_len")]
        public double? MinLen { get; set; }

        /// <summary>
        /// Default Value: 25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_len")]
        public double? MaxLen { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_scene_detection")]
        public bool? UseSceneDetection { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_asr")]
        public bool? UseAsr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_threshold")]
        public double? VadThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_vllm_whisper_asr")]
        public bool? ForceVllmWhisperAsr { get; set; }

        /// <summary>
        /// If True, chunks are sent to queue for async processing; if False, returned directly<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_chunking")]
        public bool? AsyncChunking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfigOutput" /> class.
        /// </summary>
        /// <param name="minLen">
        /// Default Value: 15
        /// </param>
        /// <param name="maxLen">
        /// Default Value: 25
        /// </param>
        /// <param name="useSceneDetection">
        /// Default Value: false
        /// </param>
        /// <param name="useAsr">
        /// Default Value: true
        /// </param>
        /// <param name="vadThreshold"></param>
        /// <param name="language"></param>
        /// <param name="forceVllmWhisperAsr">
        /// Default Value: false
        /// </param>
        /// <param name="asyncChunking">
        /// If True, chunks are sent to queue for async processing; if False, returned directly<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkingConfigOutput(
            double? minLen,
            double? maxLen,
            bool? useSceneDetection,
            bool? useAsr,
            double? vadThreshold,
            string? language,
            bool? forceVllmWhisperAsr,
            bool? asyncChunking)
        {
            this.MinLen = minLen;
            this.MaxLen = maxLen;
            this.UseSceneDetection = useSceneDetection;
            this.UseAsr = useAsr;
            this.VadThreshold = vadThreshold;
            this.Language = language;
            this.ForceVllmWhisperAsr = forceVllmWhisperAsr;
            this.AsyncChunking = asyncChunking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkingConfigOutput" /> class.
        /// </summary>
        public ChunkingConfigOutput()
        {
        }

    }
}