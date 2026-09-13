
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.InferenceRequestListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseStatus), TypeInfoPropertyName = "ResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseOutput), TypeInfoPropertyName = "ResultResponseOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoModelId), TypeInfoPropertyName = "TextToVideoModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoInputAspectRatio), TypeInfoPropertyName = "TextToVideoInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?), TypeInfoPropertyName = "NullableV2InferenceRequestsGetParametersStatusSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListItemStatus?), TypeInfoPropertyName = "NullableInferenceRequestListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.InferenceRequestListItemOutput?), TypeInfoPropertyName = "NullableInferenceRequestListItemOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseStatus?), TypeInfoPropertyName = "NullableResultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ResultResponseOutput?), TypeInfoPropertyName = "NullableResultResponseOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.StatusResponseStatus?), TypeInfoPropertyName = "NullableStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageInputAspectRatio?), TypeInfoPropertyName = "NullableTextToImageInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageInputOutputFormat?), TypeInfoPropertyName = "NullableTextToImageInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubmitResponseStatus?), TypeInfoPropertyName = "NullableSubmitResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditModelId?), TypeInfoPropertyName = "NullableEditModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.EditInputOutputFormat?), TypeInfoPropertyName = "NullableEditInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToBboxModelId?), TypeInfoPropertyName = "NullableImageToBboxModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoModelId?), TypeInfoPropertyName = "NullableImageToVideoModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ImageToVideoInputAspectRatio?), TypeInfoPropertyName = "NullableImageToVideoInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToImageModelId?), TypeInfoPropertyName = "NullableTextToImageModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechModelId?), TypeInfoPropertyName = "NullableTextToSpeechModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToSpeechInputOutputFormat?), TypeInfoPropertyName = "NullableTextToSpeechInputOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoModelId?), TypeInfoPropertyName = "NullableTextToVideoModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.TextToVideoInputAspectRatio?), TypeInfoPropertyName = "NullableTextToVideoInputAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.InferenceModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.GeneratedImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.BoundingBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.InferenceRequestListItem>))]
    internal sealed partial class InferenceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InferenceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InferenceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InferenceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Reka.Vision.JsonConverters.InferenceRequestListItemOutputJsonConverter());
            options.Converters.Add(new global::Reka.Vision.JsonConverters.ResultResponseOutputJsonConverter());
            options.Converters.Add(new global::Reka.Vision.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema)

                    || typeToConvert == typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?)

                    || typeToConvert == typeof(global::Reka.Vision.InferenceRequestListItemStatus)

                    || typeToConvert == typeof(global::Reka.Vision.InferenceRequestListItemStatus?)

                    || typeToConvert == typeof(global::Reka.Vision.ResultResponseStatus)

                    || typeToConvert == typeof(global::Reka.Vision.ResultResponseStatus?)

                    || typeToConvert == typeof(global::Reka.Vision.StatusResponseStatus)

                    || typeToConvert == typeof(global::Reka.Vision.StatusResponseStatus?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageInputAspectRatio)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageInputAspectRatio?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageInputOutputFormat)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageInputOutputFormat?)

                    || typeToConvert == typeof(global::Reka.Vision.SubmitResponseStatus)

                    || typeToConvert == typeof(global::Reka.Vision.SubmitResponseStatus?)

                    || typeToConvert == typeof(global::Reka.Vision.EditModelId)

                    || typeToConvert == typeof(global::Reka.Vision.EditModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.EditInputOutputFormat)

                    || typeToConvert == typeof(global::Reka.Vision.EditInputOutputFormat?)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToBboxModelId)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToBboxModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToVideoModelId)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToVideoModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToVideoInputAspectRatio)

                    || typeToConvert == typeof(global::Reka.Vision.ImageToVideoInputAspectRatio?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageModelId)

                    || typeToConvert == typeof(global::Reka.Vision.TextToImageModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToSpeechModelId)

                    || typeToConvert == typeof(global::Reka.Vision.TextToSpeechModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToSpeechInputOutputFormat)

                    || typeToConvert == typeof(global::Reka.Vision.TextToSpeechInputOutputFormat?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToVideoModelId)

                    || typeToConvert == typeof(global::Reka.Vision.TextToVideoModelId?)

                    || typeToConvert == typeof(global::Reka.Vision.TextToVideoInputAspectRatio)

                    || typeToConvert == typeof(global::Reka.Vision.TextToVideoInputAspectRatio?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema))
                {
                    return new global::Reka.Vision.JsonConverters.V2InferenceRequestsGetParametersStatusSchemaJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.V2InferenceRequestsGetParametersStatusSchema?))
                {
                    return new global::Reka.Vision.JsonConverters.V2InferenceRequestsGetParametersStatusSchemaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.InferenceRequestListItemStatus))
                {
                    return new global::Reka.Vision.JsonConverters.InferenceRequestListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.InferenceRequestListItemStatus?))
                {
                    return new global::Reka.Vision.JsonConverters.InferenceRequestListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ResultResponseStatus))
                {
                    return new global::Reka.Vision.JsonConverters.ResultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ResultResponseStatus?))
                {
                    return new global::Reka.Vision.JsonConverters.ResultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.StatusResponseStatus))
                {
                    return new global::Reka.Vision.JsonConverters.StatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.StatusResponseStatus?))
                {
                    return new global::Reka.Vision.JsonConverters.StatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageInputAspectRatio))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageInputAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageInputAspectRatio?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageInputAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageInputOutputFormat))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageInputOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageInputOutputFormat?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageInputOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.SubmitResponseStatus))
                {
                    return new global::Reka.Vision.JsonConverters.SubmitResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.SubmitResponseStatus?))
                {
                    return new global::Reka.Vision.JsonConverters.SubmitResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.EditModelId))
                {
                    return new global::Reka.Vision.JsonConverters.EditModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.EditModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.EditModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.EditInputOutputFormat))
                {
                    return new global::Reka.Vision.JsonConverters.EditInputOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.EditInputOutputFormat?))
                {
                    return new global::Reka.Vision.JsonConverters.EditInputOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToBboxModelId))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToBboxModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToBboxModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToBboxModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToVideoModelId))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToVideoModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToVideoModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToVideoModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToVideoInputAspectRatio))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToVideoInputAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ImageToVideoInputAspectRatio?))
                {
                    return new global::Reka.Vision.JsonConverters.ImageToVideoInputAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageModelId))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToImageModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToImageModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToSpeechModelId))
                {
                    return new global::Reka.Vision.JsonConverters.TextToSpeechModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToSpeechModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToSpeechModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToSpeechInputOutputFormat))
                {
                    return new global::Reka.Vision.JsonConverters.TextToSpeechInputOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToSpeechInputOutputFormat?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToSpeechInputOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToVideoModelId))
                {
                    return new global::Reka.Vision.JsonConverters.TextToVideoModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToVideoModelId?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToVideoModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToVideoInputAspectRatio))
                {
                    return new global::Reka.Vision.JsonConverters.TextToVideoInputAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.TextToVideoInputAspectRatio?))
                {
                    return new global::Reka.Vision.JsonConverters.TextToVideoInputAspectRatioNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new InferenceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}