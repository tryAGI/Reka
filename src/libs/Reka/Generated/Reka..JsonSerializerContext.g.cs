
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Reka
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Reka.JsonConverters.ChatMessageInputRoleJsonConverter),
            typeof(global::Reka.JsonConverters.ChatMessageInputRoleNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ContentPartTypeJsonConverter),
            typeof(global::Reka.JsonConverters.ContentPartTypeNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ToolCallTypeJsonConverter),
            typeof(global::Reka.JsonConverters.ToolCallTypeNullableJsonConverter),
            typeof(global::Reka.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter),
            typeof(global::Reka.JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ParallelThinkingConfigModeJsonConverter),
            typeof(global::Reka.JsonConverters.ParallelThinkingConfigModeNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ResponseFormatTypeJsonConverter),
            typeof(global::Reka.JsonConverters.ResponseFormatTypeNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ChatMessageOutputRoleJsonConverter),
            typeof(global::Reka.JsonConverters.ChatMessageOutputRoleNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ReasoningStepRoleJsonConverter),
            typeof(global::Reka.JsonConverters.ReasoningStepRoleNullableJsonConverter),
            typeof(global::Reka.JsonConverters.AnnotationTypeJsonConverter),
            typeof(global::Reka.JsonConverters.AnnotationTypeNullableJsonConverter),
            typeof(global::Reka.JsonConverters.ChoiceFinishReasonJsonConverter),
            typeof(global::Reka.JsonConverters.ChoiceFinishReasonNullableJsonConverter),
            typeof(global::Reka.JsonConverters.TranscribeOrTranslateRequestTargetLanguageJsonConverter),
            typeof(global::Reka.JsonConverters.TranscribeOrTranslateRequestTargetLanguageNullableJsonConverter),
            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Reka.ContentPart>>),
            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, object>),
            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, int?>),
            typeof(global::Reka.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}