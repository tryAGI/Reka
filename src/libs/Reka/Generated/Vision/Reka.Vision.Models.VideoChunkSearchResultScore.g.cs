#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Relevance score
    /// </summary>
    public readonly partial struct VideoChunkSearchResultScore : global::System.IEquatable<VideoChunkSearchResultScore>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? VideoChunkSearchResultScoreVariant1 { get; init; }
#else
        public double? VideoChunkSearchResultScoreVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoChunkSearchResultScoreVariant1))]
#endif
        public bool IsVideoChunkSearchResultScoreVariant1 => VideoChunkSearchResultScoreVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoChunkSearchResultScoreVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = VideoChunkSearchResultScoreVariant1;
            return IsVideoChunkSearchResultScoreVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickVideoChunkSearchResultScoreVariant1() => IsVideoChunkSearchResultScoreVariant1
            ? VideoChunkSearchResultScoreVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoChunkSearchResultScoreVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VideoChunkSearchResultScoreVariant2 { get; init; }
#else
        public string? VideoChunkSearchResultScoreVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoChunkSearchResultScoreVariant2))]
#endif
        public bool IsVideoChunkSearchResultScoreVariant2 => VideoChunkSearchResultScoreVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoChunkSearchResultScoreVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = VideoChunkSearchResultScoreVariant2;
            return IsVideoChunkSearchResultScoreVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickVideoChunkSearchResultScoreVariant2() => IsVideoChunkSearchResultScoreVariant2
            ? VideoChunkSearchResultScoreVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoChunkSearchResultScoreVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoChunkSearchResultScore(double value) => new VideoChunkSearchResultScore((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(VideoChunkSearchResultScore @this) => @this.VideoChunkSearchResultScoreVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VideoChunkSearchResultScore(double? value)
        {
            VideoChunkSearchResultScoreVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoChunkSearchResultScore FromVideoChunkSearchResultScoreVariant1(double? value) => new VideoChunkSearchResultScore(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoChunkSearchResultScore(string value) => new VideoChunkSearchResultScore((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VideoChunkSearchResultScore @this) => @this.VideoChunkSearchResultScoreVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VideoChunkSearchResultScore(string? value)
        {
            VideoChunkSearchResultScoreVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoChunkSearchResultScore FromVideoChunkSearchResultScoreVariant2(string? value) => new VideoChunkSearchResultScore(value);

        /// <summary>
        /// 
        /// </summary>
        public VideoChunkSearchResultScore(
            double? videoChunkSearchResultScoreVariant1,
            string? videoChunkSearchResultScoreVariant2
            )
        {
            VideoChunkSearchResultScoreVariant1 = videoChunkSearchResultScoreVariant1;
            VideoChunkSearchResultScoreVariant2 = videoChunkSearchResultScoreVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoChunkSearchResultScoreVariant2 as object ??
            VideoChunkSearchResultScoreVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoChunkSearchResultScoreVariant1?.ToString() ??
            VideoChunkSearchResultScoreVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoChunkSearchResultScoreVariant1 && !IsVideoChunkSearchResultScoreVariant2 || !IsVideoChunkSearchResultScoreVariant1 && IsVideoChunkSearchResultScoreVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? videoChunkSearchResultScoreVariant1 = null,
            global::System.Func<string, TResult>? videoChunkSearchResultScoreVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoChunkSearchResultScoreVariant1 && videoChunkSearchResultScoreVariant1 != null)
            {
                return videoChunkSearchResultScoreVariant1(VideoChunkSearchResultScoreVariant1!);
            }
            else if (IsVideoChunkSearchResultScoreVariant2 && videoChunkSearchResultScoreVariant2 != null)
            {
                return videoChunkSearchResultScoreVariant2(VideoChunkSearchResultScoreVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? videoChunkSearchResultScoreVariant1 = null,

            global::System.Action<string>? videoChunkSearchResultScoreVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoChunkSearchResultScoreVariant1)
            {
                videoChunkSearchResultScoreVariant1?.Invoke(VideoChunkSearchResultScoreVariant1!);
            }
            else if (IsVideoChunkSearchResultScoreVariant2)
            {
                videoChunkSearchResultScoreVariant2?.Invoke(VideoChunkSearchResultScoreVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<double?>? videoChunkSearchResultScoreVariant1 = null,
            global::System.Action<string>? videoChunkSearchResultScoreVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoChunkSearchResultScoreVariant1)
            {
                videoChunkSearchResultScoreVariant1?.Invoke(VideoChunkSearchResultScoreVariant1!);
            }
            else if (IsVideoChunkSearchResultScoreVariant2)
            {
                videoChunkSearchResultScoreVariant2?.Invoke(VideoChunkSearchResultScoreVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoChunkSearchResultScoreVariant1,
                typeof(double),
                VideoChunkSearchResultScoreVariant2,
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
        public bool Equals(VideoChunkSearchResultScore other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(VideoChunkSearchResultScoreVariant1, other.VideoChunkSearchResultScoreVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VideoChunkSearchResultScoreVariant2, other.VideoChunkSearchResultScoreVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoChunkSearchResultScore obj1, VideoChunkSearchResultScore obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoChunkSearchResultScore>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoChunkSearchResultScore obj1, VideoChunkSearchResultScore obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoChunkSearchResultScore o && Equals(o);
        }
    }
}
