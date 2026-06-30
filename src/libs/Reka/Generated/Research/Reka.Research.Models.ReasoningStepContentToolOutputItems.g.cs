#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReasoningStepContentToolOutputItems : global::System.IEquatable<ReasoningStepContentToolOutputItems>
    {
        /// <summary>
        /// The result of a web search, containing the URL, title, snippet, and age of the webpage from the "search_web" tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.ReasoningStepContentToolOutputItems0? ReasoningStepContentToolOutputItems0 { get; init; }
#else
        public global::Reka.Research.ReasoningStepContentToolOutputItems0? ReasoningStepContentToolOutputItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningStepContentToolOutputItems0))]
#endif
        public bool IsReasoningStepContentToolOutputItems0 => ReasoningStepContentToolOutputItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningStepContentToolOutputItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.ReasoningStepContentToolOutputItems0? value)
        {
            value = ReasoningStepContentToolOutputItems0;
            return IsReasoningStepContentToolOutputItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.ReasoningStepContentToolOutputItems0 PickReasoningStepContentToolOutputItems0() => IsReasoningStepContentToolOutputItems0
            ? ReasoningStepContentToolOutputItems0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningStepContentToolOutputItems0' but the value was {ToString()}.");

        /// <summary>
        /// The result of analyzing a webpage, containing the URL and analysis  from the "analyze" tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.ReasoningStepContentToolOutputItems1? ReasoningStepContentToolOutputItems1 { get; init; }
#else
        public global::Reka.Research.ReasoningStepContentToolOutputItems1? ReasoningStepContentToolOutputItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningStepContentToolOutputItems1))]
#endif
        public bool IsReasoningStepContentToolOutputItems1 => ReasoningStepContentToolOutputItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningStepContentToolOutputItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.ReasoningStepContentToolOutputItems1? value)
        {
            value = ReasoningStepContentToolOutputItems1;
            return IsReasoningStepContentToolOutputItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.ReasoningStepContentToolOutputItems1 PickReasoningStepContentToolOutputItems1() => IsReasoningStepContentToolOutputItems1
            ? ReasoningStepContentToolOutputItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningStepContentToolOutputItems1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningStepContentToolOutputItems(global::Reka.Research.ReasoningStepContentToolOutputItems0 value) => new ReasoningStepContentToolOutputItems((global::Reka.Research.ReasoningStepContentToolOutputItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.ReasoningStepContentToolOutputItems0?(ReasoningStepContentToolOutputItems @this) => @this.ReasoningStepContentToolOutputItems0;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepContentToolOutputItems(global::Reka.Research.ReasoningStepContentToolOutputItems0? value)
        {
            ReasoningStepContentToolOutputItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningStepContentToolOutputItems FromReasoningStepContentToolOutputItems0(global::Reka.Research.ReasoningStepContentToolOutputItems0? value) => new ReasoningStepContentToolOutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningStepContentToolOutputItems(global::Reka.Research.ReasoningStepContentToolOutputItems1 value) => new ReasoningStepContentToolOutputItems((global::Reka.Research.ReasoningStepContentToolOutputItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.ReasoningStepContentToolOutputItems1?(ReasoningStepContentToolOutputItems @this) => @this.ReasoningStepContentToolOutputItems1;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepContentToolOutputItems(global::Reka.Research.ReasoningStepContentToolOutputItems1? value)
        {
            ReasoningStepContentToolOutputItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningStepContentToolOutputItems FromReasoningStepContentToolOutputItems1(global::Reka.Research.ReasoningStepContentToolOutputItems1? value) => new ReasoningStepContentToolOutputItems(value);

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepContentToolOutputItems(
            global::Reka.Research.ReasoningStepContentToolOutputItems0? reasoningStepContentToolOutputItems0,
            global::Reka.Research.ReasoningStepContentToolOutputItems1? reasoningStepContentToolOutputItems1
            )
        {
            ReasoningStepContentToolOutputItems0 = reasoningStepContentToolOutputItems0;
            ReasoningStepContentToolOutputItems1 = reasoningStepContentToolOutputItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningStepContentToolOutputItems1 as object ??
            ReasoningStepContentToolOutputItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningStepContentToolOutputItems0?.ToString() ??
            ReasoningStepContentToolOutputItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningStepContentToolOutputItems0 && !IsReasoningStepContentToolOutputItems1 || !IsReasoningStepContentToolOutputItems0 && IsReasoningStepContentToolOutputItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Research.ReasoningStepContentToolOutputItems0, TResult>? reasoningStepContentToolOutputItems0 = null,
            global::System.Func<global::Reka.Research.ReasoningStepContentToolOutputItems1, TResult>? reasoningStepContentToolOutputItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepContentToolOutputItems0 && reasoningStepContentToolOutputItems0 != null)
            {
                return reasoningStepContentToolOutputItems0(ReasoningStepContentToolOutputItems0!);
            }
            else if (IsReasoningStepContentToolOutputItems1 && reasoningStepContentToolOutputItems1 != null)
            {
                return reasoningStepContentToolOutputItems1(ReasoningStepContentToolOutputItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Research.ReasoningStepContentToolOutputItems0>? reasoningStepContentToolOutputItems0 = null,

            global::System.Action<global::Reka.Research.ReasoningStepContentToolOutputItems1>? reasoningStepContentToolOutputItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepContentToolOutputItems0)
            {
                reasoningStepContentToolOutputItems0?.Invoke(ReasoningStepContentToolOutputItems0!);
            }
            else if (IsReasoningStepContentToolOutputItems1)
            {
                reasoningStepContentToolOutputItems1?.Invoke(ReasoningStepContentToolOutputItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Research.ReasoningStepContentToolOutputItems0>? reasoningStepContentToolOutputItems0 = null,
            global::System.Action<global::Reka.Research.ReasoningStepContentToolOutputItems1>? reasoningStepContentToolOutputItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepContentToolOutputItems0)
            {
                reasoningStepContentToolOutputItems0?.Invoke(ReasoningStepContentToolOutputItems0!);
            }
            else if (IsReasoningStepContentToolOutputItems1)
            {
                reasoningStepContentToolOutputItems1?.Invoke(ReasoningStepContentToolOutputItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningStepContentToolOutputItems0,
                typeof(global::Reka.Research.ReasoningStepContentToolOutputItems0),
                ReasoningStepContentToolOutputItems1,
                typeof(global::Reka.Research.ReasoningStepContentToolOutputItems1),
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
        public bool Equals(ReasoningStepContentToolOutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.ReasoningStepContentToolOutputItems0?>.Default.Equals(ReasoningStepContentToolOutputItems0, other.ReasoningStepContentToolOutputItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.ReasoningStepContentToolOutputItems1?>.Default.Equals(ReasoningStepContentToolOutputItems1, other.ReasoningStepContentToolOutputItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningStepContentToolOutputItems obj1, ReasoningStepContentToolOutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningStepContentToolOutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningStepContentToolOutputItems obj1, ReasoningStepContentToolOutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningStepContentToolOutputItems o && Equals(o);
        }
    }
}
