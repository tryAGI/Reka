
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Base request for all feature triggers.
    /// </summary>
    public sealed partial class FeatureTriggerRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTriggerRequest" /> class.
        /// </summary>
        /// <param name="force">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureTriggerRequest(
            bool? force)
        {
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTriggerRequest" /> class.
        /// </summary>
        public FeatureTriggerRequest()
        {
        }

    }
}