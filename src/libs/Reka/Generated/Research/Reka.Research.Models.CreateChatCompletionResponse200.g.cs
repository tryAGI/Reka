#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateChatCompletionResponse200 : global::System.IEquatable<CreateChatCompletionResponse200>
    {
        /// <summary>
        /// Represents a chat completion response returned by agent, based on the provided input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.CreateChatCompletionResponse? CreateChatCompletionResponse { get; init; }
#else
        public global::Reka.Research.CreateChatCompletionResponse? CreateChatCompletionResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatCompletionResponse))]
#endif
        public bool IsCreateChatCompletionResponse => CreateChatCompletionResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateChatCompletionResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.CreateChatCompletionResponse? value)
        {
            value = CreateChatCompletionResponse;
            return IsCreateChatCompletionResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.CreateChatCompletionResponse PickCreateChatCompletionResponse() => IsCreateChatCompletionResponse
            ? CreateChatCompletionResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateChatCompletionResponse' but the value was {ToString()}.");

        /// <summary>
        /// Represents a streamed chunk of a chat completion response returned<br/>
        /// by the agent, based on the provided input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.CreateChatCompletionStreamResponse? CreateChatCompletionStreamResponse { get; init; }
#else
        public global::Reka.Research.CreateChatCompletionStreamResponse? CreateChatCompletionStreamResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateChatCompletionStreamResponse))]
#endif
        public bool IsCreateChatCompletionStreamResponse => CreateChatCompletionStreamResponse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateChatCompletionStreamResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.CreateChatCompletionStreamResponse? value)
        {
            value = CreateChatCompletionStreamResponse;
            return IsCreateChatCompletionStreamResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.CreateChatCompletionStreamResponse PickCreateChatCompletionStreamResponse() => IsCreateChatCompletionStreamResponse
            ? CreateChatCompletionStreamResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateChatCompletionStreamResponse' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionResponse200(global::Reka.Research.CreateChatCompletionResponse value) => new CreateChatCompletionResponse200((global::Reka.Research.CreateChatCompletionResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.CreateChatCompletionResponse?(CreateChatCompletionResponse200 @this) => @this.CreateChatCompletionResponse;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionResponse200(global::Reka.Research.CreateChatCompletionResponse? value)
        {
            CreateChatCompletionResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionResponse200 FromCreateChatCompletionResponse(global::Reka.Research.CreateChatCompletionResponse? value) => new CreateChatCompletionResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionResponse200(global::Reka.Research.CreateChatCompletionStreamResponse value) => new CreateChatCompletionResponse200((global::Reka.Research.CreateChatCompletionStreamResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.CreateChatCompletionStreamResponse?(CreateChatCompletionResponse200 @this) => @this.CreateChatCompletionStreamResponse;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionResponse200(global::Reka.Research.CreateChatCompletionStreamResponse? value)
        {
            CreateChatCompletionStreamResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionResponse200 FromCreateChatCompletionStreamResponse(global::Reka.Research.CreateChatCompletionStreamResponse? value) => new CreateChatCompletionResponse200(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionResponse200(
            global::Reka.Research.CreateChatCompletionResponse? createChatCompletionResponse,
            global::Reka.Research.CreateChatCompletionStreamResponse? createChatCompletionStreamResponse
            )
        {
            CreateChatCompletionResponse = createChatCompletionResponse;
            CreateChatCompletionStreamResponse = createChatCompletionStreamResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateChatCompletionStreamResponse as object ??
            CreateChatCompletionResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateChatCompletionResponse?.ToString() ??
            CreateChatCompletionStreamResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateChatCompletionResponse && !IsCreateChatCompletionStreamResponse || !IsCreateChatCompletionResponse && IsCreateChatCompletionStreamResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Research.CreateChatCompletionResponse, TResult>? createChatCompletionResponse = null,
            global::System.Func<global::Reka.Research.CreateChatCompletionStreamResponse, TResult>? createChatCompletionStreamResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionResponse && createChatCompletionResponse != null)
            {
                return createChatCompletionResponse(CreateChatCompletionResponse!);
            }
            else if (IsCreateChatCompletionStreamResponse && createChatCompletionStreamResponse != null)
            {
                return createChatCompletionStreamResponse(CreateChatCompletionStreamResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Research.CreateChatCompletionResponse>? createChatCompletionResponse = null,

            global::System.Action<global::Reka.Research.CreateChatCompletionStreamResponse>? createChatCompletionStreamResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionResponse)
            {
                createChatCompletionResponse?.Invoke(CreateChatCompletionResponse!);
            }
            else if (IsCreateChatCompletionStreamResponse)
            {
                createChatCompletionStreamResponse?.Invoke(CreateChatCompletionStreamResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Research.CreateChatCompletionResponse>? createChatCompletionResponse = null,
            global::System.Action<global::Reka.Research.CreateChatCompletionStreamResponse>? createChatCompletionStreamResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateChatCompletionResponse)
            {
                createChatCompletionResponse?.Invoke(CreateChatCompletionResponse!);
            }
            else if (IsCreateChatCompletionStreamResponse)
            {
                createChatCompletionStreamResponse?.Invoke(CreateChatCompletionStreamResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateChatCompletionResponse,
                typeof(global::Reka.Research.CreateChatCompletionResponse),
                CreateChatCompletionStreamResponse,
                typeof(global::Reka.Research.CreateChatCompletionStreamResponse),
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
        public bool Equals(CreateChatCompletionResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.CreateChatCompletionResponse?>.Default.Equals(CreateChatCompletionResponse, other.CreateChatCompletionResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.CreateChatCompletionStreamResponse?>.Default.Equals(CreateChatCompletionStreamResponse, other.CreateChatCompletionStreamResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateChatCompletionResponse200 obj1, CreateChatCompletionResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChatCompletionResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateChatCompletionResponse200 obj1, CreateChatCompletionResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChatCompletionResponse200 o && Equals(o);
        }
    }
}
