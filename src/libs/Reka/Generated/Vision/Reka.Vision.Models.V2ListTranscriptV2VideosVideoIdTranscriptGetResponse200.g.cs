#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 : global::System.IEquatable<V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.PaginatedResponseTranscriptSegment? PaginatedResponseTranscriptSegment { get; init; }
#else
        public global::Reka.Vision.PaginatedResponseTranscriptSegment? PaginatedResponseTranscriptSegment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PaginatedResponseTranscriptSegment))]
#endif
        public bool IsPaginatedResponseTranscriptSegment => PaginatedResponseTranscriptSegment != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPaginatedResponseTranscriptSegment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.PaginatedResponseTranscriptSegment? value)
        {
            value = PaginatedResponseTranscriptSegment;
            return IsPaginatedResponseTranscriptSegment;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.PaginatedResponseTranscriptSegment PickPaginatedResponseTranscriptSegment() => IsPaginatedResponseTranscriptSegment
            ? PaginatedResponseTranscriptSegment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PaginatedResponseTranscriptSegment' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.TranscriptTextResponse? TranscriptTextResponse { get; init; }
#else
        public global::Reka.Vision.TranscriptTextResponse? TranscriptTextResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptTextResponse))]
#endif
        public bool IsTranscriptTextResponse => TranscriptTextResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptTextResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.TranscriptTextResponse? value)
        {
            value = TranscriptTextResponse;
            return IsTranscriptTextResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.TranscriptTextResponse PickTranscriptTextResponse() => IsTranscriptTextResponse
            ? TranscriptTextResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptTextResponse' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(global::Reka.Vision.PaginatedResponseTranscriptSegment value) => new V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200((global::Reka.Vision.PaginatedResponseTranscriptSegment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.PaginatedResponseTranscriptSegment?(V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 @this) => @this.PaginatedResponseTranscriptSegment;

        /// <summary>
        /// 
        /// </summary>
        public V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(global::Reka.Vision.PaginatedResponseTranscriptSegment? value)
        {
            PaginatedResponseTranscriptSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 FromPaginatedResponseTranscriptSegment(global::Reka.Vision.PaginatedResponseTranscriptSegment? value) => new V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(global::Reka.Vision.TranscriptTextResponse value) => new V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200((global::Reka.Vision.TranscriptTextResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.TranscriptTextResponse?(V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 @this) => @this.TranscriptTextResponse;

        /// <summary>
        /// 
        /// </summary>
        public V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(global::Reka.Vision.TranscriptTextResponse? value)
        {
            TranscriptTextResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 FromTranscriptTextResponse(global::Reka.Vision.TranscriptTextResponse? value) => new V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200(
            global::Reka.Vision.PaginatedResponseTranscriptSegment? paginatedResponseTranscriptSegment,
            global::Reka.Vision.TranscriptTextResponse? transcriptTextResponse
            )
        {
            PaginatedResponseTranscriptSegment = paginatedResponseTranscriptSegment;
            TranscriptTextResponse = transcriptTextResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptTextResponse as object ??
            PaginatedResponseTranscriptSegment as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginatedResponseTranscriptSegment?.ToString() ??
            TranscriptTextResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginatedResponseTranscriptSegment && !IsTranscriptTextResponse || !IsPaginatedResponseTranscriptSegment && IsTranscriptTextResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Vision.PaginatedResponseTranscriptSegment, TResult>? paginatedResponseTranscriptSegment = null,
            global::System.Func<global::Reka.Vision.TranscriptTextResponse, TResult>? transcriptTextResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedResponseTranscriptSegment && paginatedResponseTranscriptSegment != null)
            {
                return paginatedResponseTranscriptSegment(PaginatedResponseTranscriptSegment!);
            }
            else if (IsTranscriptTextResponse && transcriptTextResponse != null)
            {
                return transcriptTextResponse(TranscriptTextResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Vision.PaginatedResponseTranscriptSegment>? paginatedResponseTranscriptSegment = null,

            global::System.Action<global::Reka.Vision.TranscriptTextResponse>? transcriptTextResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedResponseTranscriptSegment)
            {
                paginatedResponseTranscriptSegment?.Invoke(PaginatedResponseTranscriptSegment!);
            }
            else if (IsTranscriptTextResponse)
            {
                transcriptTextResponse?.Invoke(TranscriptTextResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Vision.PaginatedResponseTranscriptSegment>? paginatedResponseTranscriptSegment = null,
            global::System.Action<global::Reka.Vision.TranscriptTextResponse>? transcriptTextResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginatedResponseTranscriptSegment)
            {
                paginatedResponseTranscriptSegment?.Invoke(PaginatedResponseTranscriptSegment!);
            }
            else if (IsTranscriptTextResponse)
            {
                transcriptTextResponse?.Invoke(TranscriptTextResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PaginatedResponseTranscriptSegment,
                typeof(global::Reka.Vision.PaginatedResponseTranscriptSegment),
                TranscriptTextResponse,
                typeof(global::Reka.Vision.TranscriptTextResponse),
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
        public bool Equals(V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.PaginatedResponseTranscriptSegment?>.Default.Equals(PaginatedResponseTranscriptSegment, other.PaginatedResponseTranscriptSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.TranscriptTextResponse?>.Default.Equals(TranscriptTextResponse, other.TranscriptTextResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 obj1, V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 obj1, V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V2ListTranscriptV2VideosVideoIdTranscriptGetResponse200 o && Equals(o);
        }
    }
}
