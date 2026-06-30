
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Tells the agent how to reconfigure a parent feature to unblock a dependency.
    /// </summary>
    public sealed partial class ReconfigureAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reka.Vision.JsonConverters.FeatureJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.Feature Trigger { get; set; }

        /// <summary>
        /// Request body to pass when re-triggering a parent feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Reka.Vision.ReconfigureConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureAction" /> class.
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="config">
        /// Request body to pass when re-triggering a parent feature.
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReconfigureAction(
            global::Reka.Vision.Feature trigger,
            global::Reka.Vision.ReconfigureConfig config,
            string message)
        {
            this.Trigger = trigger;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureAction" /> class.
        /// </summary>
        public ReconfigureAction()
        {
        }

    }
}