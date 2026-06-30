
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectsTriggerRequest
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_localization")]
        public global::Reka.Vision.PersonLocalizationConfig? PersonLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsTriggerRequest" /> class.
        /// </summary>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="personLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjectsTriggerRequest(
            bool? force,
            global::Reka.Vision.PersonLocalizationConfig? personLocalization)
        {
            this.Force = force;
            this.PersonLocalization = personLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsTriggerRequest" /> class.
        /// </summary>
        public ObjectsTriggerRequest()
        {
        }

    }
}