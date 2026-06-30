
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectionMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> BoundingBox { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_license_plate")]
        public bool? IsLicensePlate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_plate_number")]
        public string? LicensePlateNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ncic_category")]
        public string? NcicCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionMetadata" /> class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="boundingBox"></param>
        /// <param name="confidence"></param>
        /// <param name="isLicensePlate">
        /// Default Value: false
        /// </param>
        /// <param name="licensePlateNumber"></param>
        /// <param name="ncicCategory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetectionMetadata(
            string className,
            global::System.Collections.Generic.IList<int> boundingBox,
            double? confidence,
            bool? isLicensePlate,
            string? licensePlateNumber,
            string? ncicCategory)
        {
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.Confidence = confidence;
            this.BoundingBox = boundingBox ?? throw new global::System.ArgumentNullException(nameof(boundingBox));
            this.IsLicensePlate = isLicensePlate;
            this.LicensePlateNumber = licensePlateNumber;
            this.NcicCategory = ncicCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionMetadata" /> class.
        /// </summary>
        public DetectionMetadata()
        {
        }

    }
}