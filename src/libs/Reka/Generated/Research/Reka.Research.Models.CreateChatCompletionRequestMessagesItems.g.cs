#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateChatCompletionRequestMessagesItems : global::System.IEquatable<CreateChatCompletionRequestMessagesItems>
    {
        /// <summary>
        /// Messages sent by an end user, containing prompts or additional context<br/>
        /// information.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems0? CreateChatCompletionRequestMessagesItems0 { get; init; }
#else
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems0? CreateChatCompletionRequestMessagesItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatCompletionRequestMessagesItems0))]
#endif
        public bool IsCreateChatCompletionRequestMessagesItems0 => CreateChatCompletionRequestMessagesItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateChatCompletionRequestMessagesItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.CreateChatCompletionRequestMessagesItems0? value)
        {
            value = CreateChatCompletionRequestMessagesItems0;
            return IsCreateChatCompletionRequestMessagesItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems0 PickCreateChatCompletionRequestMessagesItems0() => IsCreateChatCompletionRequestMessagesItems0
            ? CreateChatCompletionRequestMessagesItems0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateChatCompletionRequestMessagesItems0' but the value was {ToString()}.");

        /// <summary>
        /// Messages sent by the agent in response to user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems1? CreateChatCompletionRequestMessagesItems1 { get; init; }
#else
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems1? CreateChatCompletionRequestMessagesItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatCompletionRequestMessagesItems1))]
#endif
        public bool IsCreateChatCompletionRequestMessagesItems1 => CreateChatCompletionRequestMessagesItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateChatCompletionRequestMessagesItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.CreateChatCompletionRequestMessagesItems1? value)
        {
            value = CreateChatCompletionRequestMessagesItems1;
            return IsCreateChatCompletionRequestMessagesItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.CreateChatCompletionRequestMessagesItems1 PickCreateChatCompletionRequestMessagesItems1() => IsCreateChatCompletionRequestMessagesItems1
            ? CreateChatCompletionRequestMessagesItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateChatCompletionRequestMessagesItems1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionRequestMessagesItems(global::Reka.Research.CreateChatCompletionRequestMessagesItems0 value) => new CreateChatCompletionRequestMessagesItems((global::Reka.Research.CreateChatCompletionRequestMessagesItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.CreateChatCompletionRequestMessagesItems0?(CreateChatCompletionRequestMessagesItems @this) => @this.CreateChatCompletionRequestMessagesItems0;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequestMessagesItems(global::Reka.Research.CreateChatCompletionRequestMessagesItems0? value)
        {
            CreateChatCompletionRequestMessagesItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionRequestMessagesItems FromCreateChatCompletionRequestMessagesItems0(global::Reka.Research.CreateChatCompletionRequestMessagesItems0? value) => new CreateChatCompletionRequestMessagesItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionRequestMessagesItems(global::Reka.Research.CreateChatCompletionRequestMessagesItems1 value) => new CreateChatCompletionRequestMessagesItems((global::Reka.Research.CreateChatCompletionRequestMessagesItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.CreateChatCompletionRequestMessagesItems1?(CreateChatCompletionRequestMessagesItems @this) => @this.CreateChatCompletionRequestMessagesItems1;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequestMessagesItems(global::Reka.Research.CreateChatCompletionRequestMessagesItems1? value)
        {
            CreateChatCompletionRequestMessagesItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionRequestMessagesItems FromCreateChatCompletionRequestMessagesItems1(global::Reka.Research.CreateChatCompletionRequestMessagesItems1? value) => new CreateChatCompletionRequestMessagesItems(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequestMessagesItems(
            global::Reka.Research.CreateChatCompletionRequestMessagesItems0? createChatCompletionRequestMessagesItems0,
            global::Reka.Research.CreateChatCompletionRequestMessagesItems1? createChatCompletionRequestMessagesItems1
            )
        {
            CreateChatCompletionRequestMessagesItems0 = createChatCompletionRequestMessagesItems0;
            CreateChatCompletionRequestMessagesItems1 = createChatCompletionRequestMessagesItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateChatCompletionRequestMessagesItems1 as object ??
            CreateChatCompletionRequestMessagesItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateChatCompletionRequestMessagesItems0?.ToString() ??
            CreateChatCompletionRequestMessagesItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateChatCompletionRequestMessagesItems0 && !IsCreateChatCompletionRequestMessagesItems1 || !IsCreateChatCompletionRequestMessagesItems0 && IsCreateChatCompletionRequestMessagesItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Research.CreateChatCompletionRequestMessagesItems0, TResult>? createChatCompletionRequestMessagesItems0 = null,
            global::System.Func<global::Reka.Research.CreateChatCompletionRequestMessagesItems1, TResult>? createChatCompletionRequestMessagesItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionRequestMessagesItems0 && createChatCompletionRequestMessagesItems0 != null)
            {
                return createChatCompletionRequestMessagesItems0(CreateChatCompletionRequestMessagesItems0!);
            }
            else if (IsCreateChatCompletionRequestMessagesItems1 && createChatCompletionRequestMessagesItems1 != null)
            {
                return createChatCompletionRequestMessagesItems1(CreateChatCompletionRequestMessagesItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Research.CreateChatCompletionRequestMessagesItems0>? createChatCompletionRequestMessagesItems0 = null,

            global::System.Action<global::Reka.Research.CreateChatCompletionRequestMessagesItems1>? createChatCompletionRequestMessagesItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionRequestMessagesItems0)
            {
                createChatCompletionRequestMessagesItems0?.Invoke(CreateChatCompletionRequestMessagesItems0!);
            }
            else if (IsCreateChatCompletionRequestMessagesItems1)
            {
                createChatCompletionRequestMessagesItems1?.Invoke(CreateChatCompletionRequestMessagesItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Research.CreateChatCompletionRequestMessagesItems0>? createChatCompletionRequestMessagesItems0 = null,
            global::System.Action<global::Reka.Research.CreateChatCompletionRequestMessagesItems1>? createChatCompletionRequestMessagesItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionRequestMessagesItems0)
            {
                createChatCompletionRequestMessagesItems0?.Invoke(CreateChatCompletionRequestMessagesItems0!);
            }
            else if (IsCreateChatCompletionRequestMessagesItems1)
            {
                createChatCompletionRequestMessagesItems1?.Invoke(CreateChatCompletionRequestMessagesItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateChatCompletionRequestMessagesItems0,
                typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems0),
                CreateChatCompletionRequestMessagesItems1,
                typeof(global::Reka.Research.CreateChatCompletionRequestMessagesItems1),
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
        public bool Equals(CreateChatCompletionRequestMessagesItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.CreateChatCompletionRequestMessagesItems0?>.Default.Equals(CreateChatCompletionRequestMessagesItems0, other.CreateChatCompletionRequestMessagesItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.CreateChatCompletionRequestMessagesItems1?>.Default.Equals(CreateChatCompletionRequestMessagesItems1, other.CreateChatCompletionRequestMessagesItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateChatCompletionRequestMessagesItems obj1, CreateChatCompletionRequestMessagesItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChatCompletionRequestMessagesItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateChatCompletionRequestMessagesItems obj1, CreateChatCompletionRequestMessagesItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChatCompletionRequestMessagesItems o && Equals(o);
        }
    }
}
