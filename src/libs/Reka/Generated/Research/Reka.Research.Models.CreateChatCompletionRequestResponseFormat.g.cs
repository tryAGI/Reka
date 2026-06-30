#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// An object specifying the format that the agent must output.<br/>
    /// Setting this to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs, which ensures the agent returns output that matches the supplied JSON schema.<br/>
    /// If not specified, the agent will return a plain text response.
    /// </summary>
    public readonly partial struct CreateChatCompletionRequestResponseFormat : global::System.IEquatable<CreateChatCompletionRequestResponseFormat>
    {
        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Research.ResponseFormatJsonSchema? ResponseFormatJsonSchema { get; init; }
#else
        public global::Reka.Research.ResponseFormatJsonSchema? ResponseFormatJsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFormatJsonSchema))]
#endif
        public bool IsResponseFormatJsonSchema => ResponseFormatJsonSchema != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponseFormatJsonSchema(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Research.ResponseFormatJsonSchema? value)
        {
            value = ResponseFormatJsonSchema;
            return IsResponseFormatJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Research.ResponseFormatJsonSchema PickResponseFormatJsonSchema() => IsResponseFormatJsonSchema
            ? ResponseFormatJsonSchema!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFormatJsonSchema' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateChatCompletionRequestResponseFormat(global::Reka.Research.ResponseFormatJsonSchema value) => new CreateChatCompletionRequestResponseFormat((global::Reka.Research.ResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Research.ResponseFormatJsonSchema?(CreateChatCompletionRequestResponseFormat @this) => @this.ResponseFormatJsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public CreateChatCompletionRequestResponseFormat(global::Reka.Research.ResponseFormatJsonSchema? value)
        {
            ResponseFormatJsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateChatCompletionRequestResponseFormat FromResponseFormatJsonSchema(global::Reka.Research.ResponseFormatJsonSchema? value) => new CreateChatCompletionRequestResponseFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponseFormatJsonSchema as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseFormatJsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseFormatJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Research.ResponseFormatJsonSchema, TResult>? responseFormatJsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseFormatJsonSchema && responseFormatJsonSchema != null)
            {
                return responseFormatJsonSchema(ResponseFormatJsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Research.ResponseFormatJsonSchema>? responseFormatJsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseFormatJsonSchema)
            {
                responseFormatJsonSchema?.Invoke(ResponseFormatJsonSchema!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Research.ResponseFormatJsonSchema>? responseFormatJsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseFormatJsonSchema)
            {
                responseFormatJsonSchema?.Invoke(ResponseFormatJsonSchema!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseFormatJsonSchema,
                typeof(global::Reka.Research.ResponseFormatJsonSchema),
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
        public bool Equals(CreateChatCompletionRequestResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Research.ResponseFormatJsonSchema?>.Default.Equals(ResponseFormatJsonSchema, other.ResponseFormatJsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateChatCompletionRequestResponseFormat obj1, CreateChatCompletionRequestResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateChatCompletionRequestResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateChatCompletionRequestResponseFormat obj1, CreateChatCompletionRequestResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateChatCompletionRequestResponseFormat o && Equals(o);
        }
    }
}
