#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The arguments passed to the tool.
    /// </summary>
    public readonly partial struct ReasoningStepToolCallsItemsArgs : global::System.IEquatable<ReasoningStepToolCallsItemsArgs>
    {
        /// <summary>
        /// The arguments for the `analyze` tool call, which includes the URLs to analyze and the type of analysis to perform.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs0? ReasoningStepToolCallsItemsArgs0 { get; init; }
#else
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs0? ReasoningStepToolCallsItemsArgs0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningStepToolCallsItemsArgs0))]
#endif
        public bool IsReasoningStepToolCallsItemsArgs0 => ReasoningStepToolCallsItemsArgs0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningStepToolCallsItemsArgs0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.ReasoningStepToolCallsItemsArgs0? value)
        {
            value = ReasoningStepToolCallsItemsArgs0;
            return IsReasoningStepToolCallsItemsArgs0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs0 PickReasoningStepToolCallsItemsArgs0() => IsReasoningStepToolCallsItemsArgs0
            ? ReasoningStepToolCallsItemsArgs0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningStepToolCallsItemsArgs0' but the value was {ToString()}.");

        /// <summary>
        /// The arguments for the `search_web` tool call, which includes the query and optional filters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs1? ReasoningStepToolCallsItemsArgs1 { get; init; }
#else
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs1? ReasoningStepToolCallsItemsArgs1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningStepToolCallsItemsArgs1))]
#endif
        public bool IsReasoningStepToolCallsItemsArgs1 => ReasoningStepToolCallsItemsArgs1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningStepToolCallsItemsArgs1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.ReasoningStepToolCallsItemsArgs1? value)
        {
            value = ReasoningStepToolCallsItemsArgs1;
            return IsReasoningStepToolCallsItemsArgs1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.ReasoningStepToolCallsItemsArgs1 PickReasoningStepToolCallsItemsArgs1() => IsReasoningStepToolCallsItemsArgs1
            ? ReasoningStepToolCallsItemsArgs1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningStepToolCallsItemsArgs1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningStepToolCallsItemsArgs(global::Reka.Research.ReasoningStepToolCallsItemsArgs0 value) => new ReasoningStepToolCallsItemsArgs((global::Reka.Research.ReasoningStepToolCallsItemsArgs0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.ReasoningStepToolCallsItemsArgs0?(ReasoningStepToolCallsItemsArgs @this) => @this.ReasoningStepToolCallsItemsArgs0;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepToolCallsItemsArgs(global::Reka.Research.ReasoningStepToolCallsItemsArgs0? value)
        {
            ReasoningStepToolCallsItemsArgs0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningStepToolCallsItemsArgs FromReasoningStepToolCallsItemsArgs0(global::Reka.Research.ReasoningStepToolCallsItemsArgs0? value) => new ReasoningStepToolCallsItemsArgs(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningStepToolCallsItemsArgs(global::Reka.Research.ReasoningStepToolCallsItemsArgs1 value) => new ReasoningStepToolCallsItemsArgs((global::Reka.Research.ReasoningStepToolCallsItemsArgs1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.ReasoningStepToolCallsItemsArgs1?(ReasoningStepToolCallsItemsArgs @this) => @this.ReasoningStepToolCallsItemsArgs1;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepToolCallsItemsArgs(global::Reka.Research.ReasoningStepToolCallsItemsArgs1? value)
        {
            ReasoningStepToolCallsItemsArgs1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningStepToolCallsItemsArgs FromReasoningStepToolCallsItemsArgs1(global::Reka.Research.ReasoningStepToolCallsItemsArgs1? value) => new ReasoningStepToolCallsItemsArgs(value);

        /// <summary>
        /// 
        /// </summary>
        public ReasoningStepToolCallsItemsArgs(
            global::Reka.Research.ReasoningStepToolCallsItemsArgs0? reasoningStepToolCallsItemsArgs0,
            global::Reka.Research.ReasoningStepToolCallsItemsArgs1? reasoningStepToolCallsItemsArgs1
            )
        {
            ReasoningStepToolCallsItemsArgs0 = reasoningStepToolCallsItemsArgs0;
            ReasoningStepToolCallsItemsArgs1 = reasoningStepToolCallsItemsArgs1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningStepToolCallsItemsArgs1 as object ??
            ReasoningStepToolCallsItemsArgs0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningStepToolCallsItemsArgs0?.ToString() ??
            ReasoningStepToolCallsItemsArgs1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningStepToolCallsItemsArgs0 && !IsReasoningStepToolCallsItemsArgs1 || !IsReasoningStepToolCallsItemsArgs0 && IsReasoningStepToolCallsItemsArgs1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Research.ReasoningStepToolCallsItemsArgs0, TResult>? reasoningStepToolCallsItemsArgs0 = null,
            global::System.Func<global::Reka.Research.ReasoningStepToolCallsItemsArgs1, TResult>? reasoningStepToolCallsItemsArgs1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepToolCallsItemsArgs0 && reasoningStepToolCallsItemsArgs0 != null)
            {
                return reasoningStepToolCallsItemsArgs0(ReasoningStepToolCallsItemsArgs0!);
            }
            else if (IsReasoningStepToolCallsItemsArgs1 && reasoningStepToolCallsItemsArgs1 != null)
            {
                return reasoningStepToolCallsItemsArgs1(ReasoningStepToolCallsItemsArgs1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Research.ReasoningStepToolCallsItemsArgs0>? reasoningStepToolCallsItemsArgs0 = null,

            global::System.Action<global::Reka.Research.ReasoningStepToolCallsItemsArgs1>? reasoningStepToolCallsItemsArgs1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepToolCallsItemsArgs0)
            {
                reasoningStepToolCallsItemsArgs0?.Invoke(ReasoningStepToolCallsItemsArgs0!);
            }
            else if (IsReasoningStepToolCallsItemsArgs1)
            {
                reasoningStepToolCallsItemsArgs1?.Invoke(ReasoningStepToolCallsItemsArgs1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Research.ReasoningStepToolCallsItemsArgs0>? reasoningStepToolCallsItemsArgs0 = null,
            global::System.Action<global::Reka.Research.ReasoningStepToolCallsItemsArgs1>? reasoningStepToolCallsItemsArgs1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningStepToolCallsItemsArgs0)
            {
                reasoningStepToolCallsItemsArgs0?.Invoke(ReasoningStepToolCallsItemsArgs0!);
            }
            else if (IsReasoningStepToolCallsItemsArgs1)
            {
                reasoningStepToolCallsItemsArgs1?.Invoke(ReasoningStepToolCallsItemsArgs1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningStepToolCallsItemsArgs0,
                typeof(global::Reka.Research.ReasoningStepToolCallsItemsArgs0),
                ReasoningStepToolCallsItemsArgs1,
                typeof(global::Reka.Research.ReasoningStepToolCallsItemsArgs1),
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
        public bool Equals(ReasoningStepToolCallsItemsArgs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.ReasoningStepToolCallsItemsArgs0?>.Default.Equals(ReasoningStepToolCallsItemsArgs0, other.ReasoningStepToolCallsItemsArgs0) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.ReasoningStepToolCallsItemsArgs1?>.Default.Equals(ReasoningStepToolCallsItemsArgs1, other.ReasoningStepToolCallsItemsArgs1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningStepToolCallsItemsArgs obj1, ReasoningStepToolCallsItemsArgs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningStepToolCallsItemsArgs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningStepToolCallsItemsArgs obj1, ReasoningStepToolCallsItemsArgs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningStepToolCallsItemsArgs o && Equals(o);
        }
    }
}
