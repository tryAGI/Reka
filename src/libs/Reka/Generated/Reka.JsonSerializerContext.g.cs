
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
            typeof(global::Reka.JsonConverters.CreateChatCompletionRequestToolChoiceJsonConverter),

            typeof(global::Reka.JsonConverters.CreateChatCompletionRequestToolChoiceNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ParallelThinkingConfigModeJsonConverter),

            typeof(global::Reka.JsonConverters.ParallelThinkingConfigModeNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Reka.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ChatMessageInputRoleJsonConverter),

            typeof(global::Reka.JsonConverters.ChatMessageInputRoleNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ContentPartTypeJsonConverter),

            typeof(global::Reka.JsonConverters.ContentPartTypeNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ToolCallTypeJsonConverter),

            typeof(global::Reka.JsonConverters.ToolCallTypeNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ChoiceFinishReasonJsonConverter),

            typeof(global::Reka.JsonConverters.ChoiceFinishReasonNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ChatMessageOutputRoleJsonConverter),

            typeof(global::Reka.JsonConverters.ChatMessageOutputRoleNullableJsonConverter),

            typeof(global::Reka.JsonConverters.ReasoningStepRoleJsonConverter),

            typeof(global::Reka.JsonConverters.ReasoningStepRoleNullableJsonConverter),

            typeof(global::Reka.JsonConverters.AnnotationTypeJsonConverter),

            typeof(global::Reka.JsonConverters.AnnotationTypeNullableJsonConverter),

            typeof(global::Reka.JsonConverters.TranscribeOrTranslateRequestTargetLanguageJsonConverter),

            typeof(global::Reka.JsonConverters.TranscribeOrTranslateRequestTargetLanguageNullableJsonConverter),

            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Reka.ContentPart>>),

            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Reka.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Reka.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ChatMessageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.CreateChatCompletionRequestToolChoice), TypeInfoPropertyName = "CreateChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ResearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.WebSearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ParallelThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.UserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ApproximateLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ParallelThinkingConfigMode), TypeInfoPropertyName = "ParallelThinkingConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.JsonSchemaConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ChatMessageInputRole), TypeInfoPropertyName = "ChatMessageInputRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.OneOf<string, global::System.Collections.Generic.IList<global::Reka.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ContentPartType), TypeInfoPropertyName = "ContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ToolCallType), TypeInfoPropertyName = "ToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ChatMessageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ChoiceFinishReason), TypeInfoPropertyName = "ChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ChatMessageOutputRole), TypeInfoPropertyName = "ChatMessageOutputRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ReasoningStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ReasoningStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ReasoningStepRole), TypeInfoPropertyName = "ReasoningStepRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ReasoningToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ReasoningToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.UrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.TranscribeOrTranslateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.TranscribeOrTranslateRequestTargetLanguage), TypeInfoPropertyName = "TranscribeOrTranslateRequestTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.TranscribeOrTranslateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.TimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.TimestampSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ChatMessageInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.OneOf<string, global::System.Collections.Generic.List<global::Reka.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ReasoningStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ReasoningToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.TimestampSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.OneOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}