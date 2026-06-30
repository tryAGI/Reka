#nullable enable

namespace Reka.Research
{
    public partial interface IRekaResearchClient
    {
        /// <summary>
        /// Create Chat Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Research.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Research.CreateChatCompletionResponse200> CreateChatCompletionAsync(

            global::Reka.Research.CreateChatCompletionRequest request,
            global::Reka.Research.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Research.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Research.AutoSDKHttpResponse<global::Reka.Research.CreateChatCompletionResponse200>> CreateChatCompletionAsResponseAsync(

            global::Reka.Research.CreateChatCompletionRequest request,
            global::Reka.Research.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion
        /// </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="model">
        /// The model name used to generate the response.<br/>
        /// Currently, only `"reka-flash-research"` is supported for this endpoint.<br/>
        /// Default Value: reka-flash-research
        /// </param>
        /// <param name="stream">
        /// Determines whether to stream the response incrementally.<br/>
        /// If set to `true`, the agent will return a stream of response chunks. If `false`, the response will be returned as a single object.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="research"></param>
        /// <param name="responseFormat">
        /// An object specifying the format that the agent must output.<br/>
        /// Setting this to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs, which ensures the agent returns output that matches the supplied JSON schema.<br/>
        /// If not specified, the agent will return a plain text response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Research.CreateChatCompletionResponse200> CreateChatCompletionAsync(
            global::System.Collections.Generic.IList<global::Reka.Research.CreateChatCompletionRequestMessagesItems> messages,
            string model = "reka-flash-research",
            bool? stream = default,
            global::Reka.Research.ResearchOptions? research = default,
            global::Reka.Research.ResponseFormatJsonSchema? responseFormat = default,
            global::Reka.Research.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}