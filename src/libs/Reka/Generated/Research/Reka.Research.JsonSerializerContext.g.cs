
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf0RoleJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf0RoleNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf1RoleJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsOneOf1RoleNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ResearchOptionsParallelThinkingModeJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ResearchOptionsParallelThinkingModeNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ResponseFormatJsonSchemaTypeJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ResponseFormatJsonSchemaTypeNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionResponseChoicesItemsFinishReasonJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionResponseChoicesItemsFinishReasonNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionResponseMessageRoleJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionResponseMessageRoleNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepRoleJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepRoleNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepToolCallsItemsNameJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepToolCallsItemsNameNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepContentToolNameJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepContentToolNameNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionResponseMessageAnnotationsItemsTypeJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionResponseMessageAnnotationsItemsTypeNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionStreamResponseDeltaRoleJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ChatCompletionStreamResponseDeltaRoleNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionStreamResponseChoicesItemsFinishReasonJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionStreamResponseChoicesItemsFinishReasonNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionStreamResponseObjectJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionStreamResponseObjectNullableJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestMessagesItemsJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionRequestResponseFormatJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepToolCallsItemsArgsJsonConverter),

            typeof(global::Reka.Research.JsonConverters.ReasoningStepContentToolOutputItemsJsonConverter),

            typeof(global::Reka.Research.JsonConverters.CreateChatCompletionResponse200JsonConverter),

            typeof(global::Reka.Research.JsonConverters.OneOfJsonConverter<global::Reka.Research.ReasoningStepContent, object>),

            typeof(global::Reka.Research.JsonConverters.OneOfJsonConverter<global::Reka.Research.CreateChatCompletionStreamResponseChoicesItemsFinishReason?, object>),

            typeof(global::Reka.Research.JsonConverters.OneOfJsonConverter<global::Reka.Research.CompletionUsage, object>),

            typeof(global::Reka.Research.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf0Role), TypeInfoPropertyName = "CreateChatCompletionRequestMessagesItemsOneOf0Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItemsOneOf1Role), TypeInfoPropertyName = "CreateChatCompletionRequestMessagesItemsOneOf1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems), TypeInfoPropertyName = "CreateChatCompletionRequestMessagesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptionsWebSearchUserLocationApproximate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptionsWebSearchUserLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptionsWebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptionsParallelThinkingMode), TypeInfoPropertyName = "ResearchOptionsParallelThinkingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptionsParallelThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResponseFormatJsonSchemaType), TypeInfoPropertyName = "ResponseFormatJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResponseFormatJsonSchemaSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResponseFormatJsonSchemaJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequestResponseFormat), TypeInfoPropertyName = "CreateChatCompletionRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionRequestMessagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionResponseChoicesItemsFinishReason), TypeInfoPropertyName = "CreateChatCompletionResponseChoicesItemsFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionResponseMessageRole), TypeInfoPropertyName = "ChatCompletionResponseMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepRole), TypeInfoPropertyName = "ReasoningStepRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepToolCallsItemsName), TypeInfoPropertyName = "ReasoningStepToolCallsItemsName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepToolCallsItemsArgs0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepToolCallsItemsArgs1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepToolCallsItemsArgs), TypeInfoPropertyName = "ReasoningStepToolCallsItemsArgs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepToolCallsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepContentToolName), TypeInfoPropertyName = "ReasoningStepContentToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepContentToolOutputItems), TypeInfoPropertyName = "ReasoningStepContentToolOutputItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStepContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepContentToolOutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ReasoningStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStepToolCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.OneOf<global::Reka.Research.ReasoningStepContent, object>), TypeInfoPropertyName = "OneOfReasoningStepContentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsType), TypeInfoPropertyName = "ChatCompletionResponseMessageAnnotationsItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionResponseMessageAnnotationsItemsUrlCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionResponseMessageAnnotationsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.ReasoningStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.ChatCompletionResponseMessageAnnotationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionResponseChoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionResponseChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionStreamResponseDeltaRole), TypeInfoPropertyName = "ChatCompletionStreamResponseDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.ChatCompletionStreamResponseDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionStreamResponseChoicesItemsFinishReason), TypeInfoPropertyName = "CreateChatCompletionStreamResponseChoicesItemsFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionStreamResponseChoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.OneOf<global::Reka.Research.CreateChatCompletionStreamResponseChoicesItemsFinishReason?, object>), TypeInfoPropertyName = "OneOfCreateChatCompletionStreamResponseChoicesItemsFinishReasonObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionStreamResponseObject), TypeInfoPropertyName = "CreateChatCompletionStreamResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionStreamResponseChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.OneOf<global::Reka.Research.CompletionUsage, object>), TypeInfoPropertyName = "OneOfCompletionUsageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Research.CreateChatCompletionResponse200), TypeInfoPropertyName = "CreateChatCompletionResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.CreateChatCompletionRequestMessagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.ReasoningStepContentToolOutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.ReasoningStepToolCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.ReasoningStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.ChatCompletionResponseMessageAnnotationsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.CreateChatCompletionResponseChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Research.CreateChatCompletionStreamResponseChoicesItems>))]
    public sealed partial class ResearchJsonSerializerContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}