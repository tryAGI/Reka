
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeaturePlanRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Reka.Vision.Feature> Desired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturePlanRequest" /> class.
        /// </summary>
        /// <param name="desired"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeaturePlanRequest(
            global::System.Collections.Generic.IList<global::Reka.Vision.Feature> desired)
        {
            this.Desired = desired ?? throw new global::System.ArgumentNullException(nameof(desired));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturePlanRequest" /> class.
        /// </summary>
        public FeaturePlanRequest()
        {
        }

    }
}