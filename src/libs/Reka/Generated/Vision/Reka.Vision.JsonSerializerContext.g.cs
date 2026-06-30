
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Reka.Vision.JsonConverters.CaptionModeJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionModeNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoIndexingStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoIndexingStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.UserIndexingParamsJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.UserIndexingParamsNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoQaResponseStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoQaResponseStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ReelQualityJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ReelQualityNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoGenerationTemplateJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoGenerationTemplateNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SubtitleTranslationLocaleJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SubtitleTranslationLocaleNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.AspectRatioJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoResolutionJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoResolutionNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigTextTransformJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigTextTransformNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigPositionJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigPositionNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigFontFamilyJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.CaptionFontConfigFontFamilyNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ClipLayoutJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ClipLayoutNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageSearchRequestSearchModeJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageSearchRequestSearchModeNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoUploadStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoUploadStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.FeatureStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.FeatureStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.FeatureJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.FeatureNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ChunkerTypeJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ChunkerTypeNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SearchStrategyJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SearchStrategyNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SearchTextFieldJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SearchTextFieldNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ThresholdLevelJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ThresholdLevelNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ChatMessageRoleJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ChatMessageRoleNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SegmentPromptTypeJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SegmentPromptTypeNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.V2InferenceRequestsGetParametersStatusSchemaJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.V2InferenceRequestsGetParametersStatusSchemaNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.InferenceRequestListItemStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.InferenceRequestListItemStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ResultResponseStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ResultResponseStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.StatusResponseStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.StatusResponseStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageInputAspectRatioJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageInputAspectRatioNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageInputOutputFormatJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageInputOutputFormatNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SubmitResponseStatusJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.SubmitResponseStatusNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.EditModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.EditModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.EditInputOutputFormatJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.EditInputOutputFormatNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToBboxModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToBboxModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToVideoModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToVideoModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToVideoInputAspectRatioJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ImageToVideoInputAspectRatioNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToImageModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToSpeechModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToSpeechModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToSpeechInputOutputFormatJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToSpeechInputOutputFormatNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToVideoModelIdJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToVideoModelIdNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToVideoInputAspectRatioJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.TextToVideoInputAspectRatioNullableJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoChunkSearchResultScoreJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.VideoQaResponseChatResponseJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200JsonConverter),

            typeof(global::Reka.Vision.JsonConverters.V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200JsonConverter),

            typeof(global::Reka.Vision.JsonConverters.InferenceRequestListItemOutputJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.ResultResponseOutputJsonConverter),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoIndexingStatus?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.UserIndexingParams?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoQaResponseChatResponse?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.SubtitleTranslationLocale?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigTextTransform?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigPosition?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfigFontFamily?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.CaptionFontConfig, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.SubtitleTranslationLocale?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.ClipGenerationConfigResult, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.ClipRenderingConfig, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoUploadStatus?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VideoMetadata, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.NumberFilter, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.SearchFilter, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.FrameSize, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.InferenceRequestListItemOutput?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.ResultResponseOutput?, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.VoiceSettingsInput, object>),

            typeof(global::Reka.Vision.JsonConverters.OneOfJsonConverter<global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?, object>),

            typeof(global::Reka.Vision.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionMode), TypeInfoPropertyName = "CaptionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoIndexingStatus), TypeInfoPropertyName = "VideoIndexingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.UserIndexingParams), TypeInfoPropertyName = "UserIndexingParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideosGetResponseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.VideoMetadata, object>), TypeInfoPropertyName = "OneOfVideoMetadataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.VideoIndexingStatus?, object>), TypeInfoPropertyName = "OneOfVideoIndexingStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.UserIndexingParams?, object>), TypeInfoPropertyName = "OneOfUserIndexingParamsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideosGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.VideosGetResponseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoGroupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoGroupListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoGroupUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoGroupDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoChunkSearchResultScore), TypeInfoPropertyName = "VideoChunkSearchResultScore2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoChunkSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.VideoChunkSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SimpleChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoQARequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SimpleChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoQaResponseChatResponse), TypeInfoPropertyName = "VideoQaResponseChatResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoQaResponseStatus), TypeInfoPropertyName = "VideoQaResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoQAResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.VideoQaResponseChatResponse?, object>), TypeInfoPropertyName = "OneOfVideoQaResponseChatResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoTaggingAdvertisingResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoTaggingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200), TypeInfoPropertyName = "MetadataTaggingIndexedTagV1QaIndexedtagPostResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ReelQuality), TypeInfoPropertyName = "ReelQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoGenerationTemplate), TypeInfoPropertyName = "VideoGenerationTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubtitleTranslationLocale), TypeInfoPropertyName = "SubtitleTranslationLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.SubtitleTranslationLocale?, object>), TypeInfoPropertyName = "OneOfSubtitleTranslationLocaleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoResolution), TypeInfoPropertyName = "VideoResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigTextTransform), TypeInfoPropertyName = "CaptionFontConfigTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigPosition), TypeInfoPropertyName = "CaptionFontConfigPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigFontFamily), TypeInfoPropertyName = "CaptionFontConfigFontFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigTextTransform?, object>), TypeInfoPropertyName = "OneOfCaptionFontConfigTextTransformObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigPosition?, object>), TypeInfoPropertyName = "OneOfCaptionFontConfigPositionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfigFontFamily?, object>), TypeInfoPropertyName = "OneOfCaptionFontConfigFontFamilyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipLayout), TypeInfoPropertyName = "ClipLayout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipRenderingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.CaptionFontConfig, object>), TypeInfoPropertyName = "OneOfCaptionFontConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipGenerationConfigResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.ClipGenerationConfigResult, object>), TypeInfoPropertyName = "OneOfClipGenerationConfigResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.ClipRenderingConfig, object>), TypeInfoPropertyName = "OneOfClipRenderingConfigObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ClipOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageUploadBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ImageUploadResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageSearchRequestSearchMode), TypeInfoPropertyName = "ImageSearchRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.DetectionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SecurityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.DetectionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ImageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoUploadStatus), TypeInfoPropertyName = "VideoUploadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeatureStatus), TypeInfoPropertyName = "FeatureStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.VideoUploadStatus?, object>), TypeInfoPropertyName = "OneOfVideoUploadStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.FeatureStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.VideoResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoMetadataUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoMoveGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorApiV2ModelsVideoMoveGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeatureInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeatureCatalogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.FeatureInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.Feature), TypeInfoPropertyName = "Feature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeaturePlanRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.Feature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChunkingConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ReconfigureConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ReconfigureAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeaturePlanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Reka.Vision.ReconfigureAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionsTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeatureTriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.PersonLocalizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ObjectsTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FeatureTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChunkerType), TypeInfoPropertyName = "ChunkerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChunkingConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TranscriptTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SearchStrategy), TypeInfoPropertyName = "SearchStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SearchTextField), TypeInfoPropertyName = "SearchTextField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ThresholdLevel), TypeInfoPropertyName = "ThresholdLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.NumberFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SearchFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.NumberFilter, object>), TypeInfoPropertyName = "OneOfNumberFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SearchTextField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.SearchFilter, object>), TypeInfoPropertyName = "OneOfSearchFilterObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2SearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SearchPool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.V2SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChatVideoContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2ChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ChatVideoContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2ChatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.PaginatedResponseCaptionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.CaptionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TranscriptSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.PaginatedResponseTranscriptSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.TranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TranscriptTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200), TypeInfoPropertyName = "V2ListTranscriptV2VideosVideoIdTranscriptGetResponse2002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SceneEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.PaginatedResponseSceneEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SceneEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.Detection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ObjectSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.Detection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.PaginatedResponseObjectSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ObjectSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentPromptType), TypeInfoPropertyName = "SegmentPromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SegmentPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentBoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SegmentDetection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.FrameSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SegmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.SegmentFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.FrameSize, object>), TypeInfoPropertyName = "OneOfFrameSizeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.InferenceModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema), TypeInfoPropertyName = "V2InferenceRequestsGetParametersStatusSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListItemStatus), TypeInfoPropertyName = "InferenceRequestListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.GeneratedImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.GeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.BoundingBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToBboxOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.BoundingBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListItemOutput), TypeInfoPropertyName = "InferenceRequestListItemOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.InferenceRequestListItemOutput?, object>), TypeInfoPropertyName = "OneOfInferenceRequestListItemOutputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.InferenceRequestListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseStatus), TypeInfoPropertyName = "ResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseOutput), TypeInfoPropertyName = "ResultResponseOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.ResultResponseOutput?, object>), TypeInfoPropertyName = "OneOfResultResponseOutputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.StatusResponseStatus), TypeInfoPropertyName = "StatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.StatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageInputAspectRatio), TypeInfoPropertyName = "TextToImageInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageInputOutputFormat), TypeInfoPropertyName = "TextToImageInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubmitResponseStatus), TypeInfoPropertyName = "SubmitResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubmitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditModelId), TypeInfoPropertyName = "EditModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditInputOutputFormat), TypeInfoPropertyName = "EditInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToBboxModelId), TypeInfoPropertyName = "ImageToBboxModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToBboxInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToBboxSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoModelId), TypeInfoPropertyName = "ImageToVideoModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoInputAspectRatio), TypeInfoPropertyName = "ImageToVideoInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageModelId), TypeInfoPropertyName = "TextToImageModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechModelId), TypeInfoPropertyName = "TextToSpeechModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechInputOutputFormat), TypeInfoPropertyName = "TextToSpeechInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VoiceSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.VoiceSettingsInput, object>), TypeInfoPropertyName = "OneOfVoiceSettingsInputObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoModelId), TypeInfoPropertyName = "TextToVideoModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoInputAspectRatio), TypeInfoPropertyName = "TextToVideoInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoMoveGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OrchestratorProtocolVideoMoveGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ClipListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.UploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.QuickTagV1QaQuicktagPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.UploadImagesV1ImagesUploadPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.UploadVideoV2VideosPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.OneOf<global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?, object>), TypeInfoPropertyName = "OneOfV2InferenceRequestsGetParametersStatusSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.VideosGetResponseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.OrchestratorProtocolVideoGroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.VideoChunkSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SimpleChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ClipOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ImageUploadResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.DetectionMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ImageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.VideoResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.OrchestratorApiV2ModelsVideoGroupResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.FeatureInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.Feature>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SearchTextField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.V2SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ChatVideoContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.CaptionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.TranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SceneEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.Detection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ObjectSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SegmentPrompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SegmentDetection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.SegmentFrame>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.InferenceModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.GeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.BoundingBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.InferenceRequestListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ClipListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    public sealed partial class VisionJsonSerializerContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}