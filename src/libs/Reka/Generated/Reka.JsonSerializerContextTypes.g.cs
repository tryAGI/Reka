
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Reka
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.CreateChatCompletionRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ChatMessageInput>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ChatMessageInput? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ChatMessageInputRole? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.OneOf<string, global::System.Collections.Generic.IList<global::Reka.ContentPart>>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ContentPart>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ContentPart? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ContentPartType? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ToolCall>? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ToolCall? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ToolCallType? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.FunctionCall? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.Tool>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Tool? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.CreateChatCompletionRequestToolChoice? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ResearchConfig? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.WebSearchConfig? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.UserLocation? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ApproximateLocation? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ParallelThinkingConfig? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ParallelThinkingConfigMode? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ResponseFormat? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ResponseFormatType? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.JsonSchemaConfig? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.CreateChatCompletionResponse? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.Choice>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Choice? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ChatMessageOutput? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ChatMessageOutputRole? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ReasoningStep>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ReasoningStep? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ReasoningStepRole? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.OneOf<string, object>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ReasoningToolCall>? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ReasoningToolCall? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.Annotation>? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Annotation? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.AnnotationType? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.UrlCitation? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ChoiceFinishReason? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Usage? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ListModelsResponse? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.Model>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Model? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.TranscribeOrTranslateRequest? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.TranscribeOrTranslateRequestTargetLanguage? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.TranscribeOrTranslateResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.TimestampSegment>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.TimestampSegment? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.HTTPValidationError? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.ValidationError>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.ValidationError? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Reka.OneOf<string, int?>>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.OneOf<string, int?>? Type60 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ChatMessageInput>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Reka.OneOf<string, global::System.Collections.Generic.List<global::Reka.ContentPart>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ContentPart>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ToolCall>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.Tool>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.Choice>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ReasoningStep>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ReasoningToolCall>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.Annotation>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.Model>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.TimestampSegment>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.ValidationError>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Reka.OneOf<string, int?>>? ListType13 { get; set; }
    }
}