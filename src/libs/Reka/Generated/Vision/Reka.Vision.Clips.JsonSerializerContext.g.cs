
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ReelQuality), TypeInfoPropertyName = "ReelQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoGenerationTemplate), TypeInfoPropertyName = "VideoGenerationTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubtitleTranslationLocale), TypeInfoPropertyName = "SubtitleTranslationLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoResolution), TypeInfoPropertyName = "VideoResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigTextTransform), TypeInfoPropertyName = "CaptionFontConfigTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigPosition), TypeInfoPropertyName = "CaptionFontConfigPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigFontFamily), TypeInfoPropertyName = "CaptionFontConfigFontFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipLayout), TypeInfoPropertyName = "ClipLayout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipRenderingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipGenerationConfigResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ClipOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Reka.Vision.ClipListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ReelQuality?), TypeInfoPropertyName = "NullableReelQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoGenerationTemplate?), TypeInfoPropertyName = "NullableVideoGenerationTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.SubtitleTranslationLocale?), TypeInfoPropertyName = "NullableSubtitleTranslationLocale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.AspectRatio?), TypeInfoPropertyName = "NullableAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.VideoResolution?), TypeInfoPropertyName = "NullableVideoResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigTextTransform?), TypeInfoPropertyName = "NullableCaptionFontConfigTextTransform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigPosition?), TypeInfoPropertyName = "NullableCaptionFontConfigPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.CaptionFontConfigFontFamily?), TypeInfoPropertyName = "NullableCaptionFontConfigFontFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Reka.Vision.ClipLayout?), TypeInfoPropertyName = "NullableClipLayout2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ClipOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Reka.Vision.ClipListItem>))]
    internal sealed partial class ClipsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClipsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ClipsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ClipsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Reka.Vision.ReelQuality)

                    || typeToConvert == typeof(global::Reka.Vision.ReelQuality?)

                    || typeToConvert == typeof(global::Reka.Vision.VideoGenerationTemplate)

                    || typeToConvert == typeof(global::Reka.Vision.VideoGenerationTemplate?)

                    || typeToConvert == typeof(global::Reka.Vision.SubtitleTranslationLocale)

                    || typeToConvert == typeof(global::Reka.Vision.SubtitleTranslationLocale?)

                    || typeToConvert == typeof(global::Reka.Vision.AspectRatio)

                    || typeToConvert == typeof(global::Reka.Vision.AspectRatio?)

                    || typeToConvert == typeof(global::Reka.Vision.VideoResolution)

                    || typeToConvert == typeof(global::Reka.Vision.VideoResolution?)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigTextTransform)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigTextTransform?)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigPosition)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigPosition?)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigFontFamily)

                    || typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigFontFamily?)

                    || typeToConvert == typeof(global::Reka.Vision.ClipLayout)

                    || typeToConvert == typeof(global::Reka.Vision.ClipLayout?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Reka.Vision.ReelQuality))
                {
                    return new global::Reka.Vision.JsonConverters.ReelQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ReelQuality?))
                {
                    return new global::Reka.Vision.JsonConverters.ReelQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.VideoGenerationTemplate))
                {
                    return new global::Reka.Vision.JsonConverters.VideoGenerationTemplateJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.VideoGenerationTemplate?))
                {
                    return new global::Reka.Vision.JsonConverters.VideoGenerationTemplateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.SubtitleTranslationLocale))
                {
                    return new global::Reka.Vision.JsonConverters.SubtitleTranslationLocaleJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.SubtitleTranslationLocale?))
                {
                    return new global::Reka.Vision.JsonConverters.SubtitleTranslationLocaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.AspectRatio))
                {
                    return new global::Reka.Vision.JsonConverters.AspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.AspectRatio?))
                {
                    return new global::Reka.Vision.JsonConverters.AspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.VideoResolution))
                {
                    return new global::Reka.Vision.JsonConverters.VideoResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.VideoResolution?))
                {
                    return new global::Reka.Vision.JsonConverters.VideoResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigTextTransform))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigTextTransformJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigTextTransform?))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigTextTransformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigPosition))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigPosition?))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigFontFamily))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigFontFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.CaptionFontConfigFontFamily?))
                {
                    return new global::Reka.Vision.JsonConverters.CaptionFontConfigFontFamilyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ClipLayout))
                {
                    return new global::Reka.Vision.JsonConverters.ClipLayoutJsonConverter();
                }

                if (typeToConvert == typeof(global::Reka.Vision.ClipLayout?))
                {
                    return new global::Reka.Vision.JsonConverters.ClipLayoutNullableJsonConverter();
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
                    0 => new ClipsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}