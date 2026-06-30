
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Request body to pass when re-triggering a parent feature.
    /// </summary>
    public sealed partial class ReconfigureConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.ChunkingConfigOutput ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureConfig" /> class.
        /// </summary>
        /// <param name="chunkingConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReconfigureConfig(
            global::Reka.Vision.ChunkingConfigOutput chunkingConfig)
        {
            this.ChunkingConfig = chunkingConfig ?? throw new global::System.ArgumentNullException(nameof(chunkingConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureConfig" /> class.
        /// </summary>
        public ReconfigureConfig()
        {
        }

    }
}