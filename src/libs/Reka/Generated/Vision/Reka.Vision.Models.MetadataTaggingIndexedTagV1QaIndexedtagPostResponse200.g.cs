#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 : global::System.IEquatable<MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.VideoTaggingAdvertisingResult? VideoTaggingAdvertisingResult { get; init; }
#else
        public global::Reka.Vision.VideoTaggingAdvertisingResult? VideoTaggingAdvertisingResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoTaggingAdvertisingResult))]
#endif
        public bool IsVideoTaggingAdvertisingResult => VideoTaggingAdvertisingResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoTaggingAdvertisingResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.VideoTaggingAdvertisingResult? value)
        {
            value = VideoTaggingAdvertisingResult;
            return IsVideoTaggingAdvertisingResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.VideoTaggingAdvertisingResult PickVideoTaggingAdvertisingResult() => IsVideoTaggingAdvertisingResult
            ? VideoTaggingAdvertisingResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoTaggingAdvertisingResult' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 { get; init; }
#else
        public string? MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2))]
#endif
        public bool IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 => MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2;
            return IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2() => IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2
            ? MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(global::Reka.Vision.VideoTaggingAdvertisingResult value) => new MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200((global::Reka.Vision.VideoTaggingAdvertisingResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.VideoTaggingAdvertisingResult?(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 @this) => @this.VideoTaggingAdvertisingResult;

        /// <summary>
        /// 
        /// </summary>
        public MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(global::Reka.Vision.VideoTaggingAdvertisingResult? value)
        {
            VideoTaggingAdvertisingResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 FromVideoTaggingAdvertisingResult(global::Reka.Vision.VideoTaggingAdvertisingResult? value) => new MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(string value) => new MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 @this) => @this.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2;

        /// <summary>
        /// 
        /// </summary>
        public MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(string? value)
        {
            MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 FromMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2(string? value) => new MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200(
            global::Reka.Vision.VideoTaggingAdvertisingResult? videoTaggingAdvertisingResult,
            string? metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2
            )
        {
            VideoTaggingAdvertisingResult = videoTaggingAdvertisingResult;
            MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 as object ??
            VideoTaggingAdvertisingResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoTaggingAdvertisingResult?.ToString() ??
            MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoTaggingAdvertisingResult && !IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 || !IsVideoTaggingAdvertisingResult && IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Vision.VideoTaggingAdvertisingResult, TResult>? videoTaggingAdvertisingResult = null,
            global::System.Func<string, TResult>? metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoTaggingAdvertisingResult && videoTaggingAdvertisingResult != null)
            {
                return videoTaggingAdvertisingResult(VideoTaggingAdvertisingResult!);
            }
            else if (IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 && metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 != null)
            {
                return metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Vision.VideoTaggingAdvertisingResult>? videoTaggingAdvertisingResult = null,

            global::System.Action<string>? metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoTaggingAdvertisingResult)
            {
                videoTaggingAdvertisingResult?.Invoke(VideoTaggingAdvertisingResult!);
            }
            else if (IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2)
            {
                metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2?.Invoke(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Vision.VideoTaggingAdvertisingResult>? videoTaggingAdvertisingResult = null,
            global::System.Action<string>? metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoTaggingAdvertisingResult)
            {
                videoTaggingAdvertisingResult?.Invoke(VideoTaggingAdvertisingResult!);
            }
            else if (IsMetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2)
            {
                metadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2?.Invoke(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoTaggingAdvertisingResult,
                typeof(global::Reka.Vision.VideoTaggingAdvertisingResult),
                MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2,
                typeof(string),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.VideoTaggingAdvertisingResult?>.Default.Equals(VideoTaggingAdvertisingResult, other.VideoTaggingAdvertisingResult) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2, other.MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200Variant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 obj1, MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 obj1, MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataTaggingIndexedTagV1QaIndexedtagPostResponse200 o && Equals(o);
        }
    }
}
