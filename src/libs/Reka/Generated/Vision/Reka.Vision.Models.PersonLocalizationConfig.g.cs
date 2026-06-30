
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonLocalizationConfig
    {
        /// <summary>
        /// Default Value: 15
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_fps")]
        public int? MaxFps { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_failed_frames")]
        public int? MaxFailedFrames { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_photos_per_person")]
        public int? NumPhotosPerPerson { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_objects_per_chunk")]
        public int? MaxObjectsPerChunk { get; set; }

        /// <summary>
        /// Default Value: 0.9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conf")]
        public double? Conf { get; set; }

        /// <summary>
        /// Default Value: 0.7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou")]
        public double? Iou { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLocalizationConfig" /> class.
        /// </summary>
        /// <param name="maxFps">
        /// Default Value: 15
        /// </param>
        /// <param name="maxFailedFrames">
        /// Default Value: 10
        /// </param>
        /// <param name="numPhotosPerPerson">
        /// Default Value: 3
        /// </param>
        /// <param name="maxObjectsPerChunk">
        /// Default Value: 10
        /// </param>
        /// <param name="conf">
        /// Default Value: 0.9
        /// </param>
        /// <param name="iou">
        /// Default Value: 0.7
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonLocalizationConfig(
            int? maxFps,
            int? maxFailedFrames,
            int? numPhotosPerPerson,
            int? maxObjectsPerChunk,
            double? conf,
            double? iou)
        {
            this.MaxFps = maxFps;
            this.MaxFailedFrames = maxFailedFrames;
            this.NumPhotosPerPerson = numPhotosPerPerson;
            this.MaxObjectsPerChunk = maxObjectsPerChunk;
            this.Conf = conf;
            this.Iou = iou;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonLocalizationConfig" /> class.
        /// </summary>
        public PersonLocalizationConfig()
        {
        }

    }
}