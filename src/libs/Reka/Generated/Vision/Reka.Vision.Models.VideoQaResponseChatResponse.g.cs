#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VideoQaResponseChatResponse : global::System.IEquatable<VideoQaResponseChatResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VideoQaResponseChatResponseVariant1 { get; init; }
#else
        public string? VideoQaResponseChatResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoQaResponseChatResponseVariant1))]
#endif
        public bool IsVideoQaResponseChatResponseVariant1 => VideoQaResponseChatResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoQaResponseChatResponseVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = VideoQaResponseChatResponseVariant1;
            return IsVideoQaResponseChatResponseVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickVideoQaResponseChatResponseVariant1() => IsVideoQaResponseChatResponseVariant1
            ? VideoQaResponseChatResponseVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoQaResponseChatResponseVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? VideoQaResponseChatResponseVariant2 { get; init; }
#else
        public object? VideoQaResponseChatResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoQaResponseChatResponseVariant2))]
#endif
        public bool IsVideoQaResponseChatResponseVariant2 => VideoQaResponseChatResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoQaResponseChatResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = VideoQaResponseChatResponseVariant2;
            return IsVideoQaResponseChatResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickVideoQaResponseChatResponseVariant2() => IsVideoQaResponseChatResponseVariant2
            ? VideoQaResponseChatResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoQaResponseChatResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VideoQaResponseChatResponse(string value) => new VideoQaResponseChatResponse((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VideoQaResponseChatResponse @this) => @this.VideoQaResponseChatResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VideoQaResponseChatResponse(string? value)
        {
            VideoQaResponseChatResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VideoQaResponseChatResponse FromVideoQaResponseChatResponseVariant1(string? value) => new VideoQaResponseChatResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public VideoQaResponseChatResponse(
            string? videoQaResponseChatResponseVariant1,
            object? videoQaResponseChatResponseVariant2
            )
        {
            VideoQaResponseChatResponseVariant1 = videoQaResponseChatResponseVariant1;
            VideoQaResponseChatResponseVariant2 = videoQaResponseChatResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoQaResponseChatResponseVariant2 as object ??
            VideoQaResponseChatResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoQaResponseChatResponseVariant1?.ToString() ??
            VideoQaResponseChatResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoQaResponseChatResponseVariant1 && !IsVideoQaResponseChatResponseVariant2 || !IsVideoQaResponseChatResponseVariant1 && IsVideoQaResponseChatResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? videoQaResponseChatResponseVariant1 = null,
            global::System.Func<object, TResult>? videoQaResponseChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoQaResponseChatResponseVariant1 && videoQaResponseChatResponseVariant1 != null)
            {
                return videoQaResponseChatResponseVariant1(VideoQaResponseChatResponseVariant1!);
            }
            else if (IsVideoQaResponseChatResponseVariant2 && videoQaResponseChatResponseVariant2 != null)
            {
                return videoQaResponseChatResponseVariant2(VideoQaResponseChatResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? videoQaResponseChatResponseVariant1 = null,

            global::System.Action<object>? videoQaResponseChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoQaResponseChatResponseVariant1)
            {
                videoQaResponseChatResponseVariant1?.Invoke(VideoQaResponseChatResponseVariant1!);
            }
            else if (IsVideoQaResponseChatResponseVariant2)
            {
                videoQaResponseChatResponseVariant2?.Invoke(VideoQaResponseChatResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? videoQaResponseChatResponseVariant1 = null,
            global::System.Action<object>? videoQaResponseChatResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoQaResponseChatResponseVariant1)
            {
                videoQaResponseChatResponseVariant1?.Invoke(VideoQaResponseChatResponseVariant1!);
            }
            else if (IsVideoQaResponseChatResponseVariant2)
            {
                videoQaResponseChatResponseVariant2?.Invoke(VideoQaResponseChatResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoQaResponseChatResponseVariant1,
                typeof(string),
                VideoQaResponseChatResponseVariant2,
                typeof(object),
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
        public bool Equals(VideoQaResponseChatResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VideoQaResponseChatResponseVariant1, other.VideoQaResponseChatResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(VideoQaResponseChatResponseVariant2, other.VideoQaResponseChatResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VideoQaResponseChatResponse obj1, VideoQaResponseChatResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoQaResponseChatResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VideoQaResponseChatResponse obj1, VideoQaResponseChatResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoQaResponseChatResponse o && Equals(o);
        }
    }
}
