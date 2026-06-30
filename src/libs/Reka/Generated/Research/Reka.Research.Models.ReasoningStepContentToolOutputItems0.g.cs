
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The result of a web search, containing the URL, title, snippet, and age of the webpage from the "search_web" tool.
    /// </summary>
    public sealed partial class ReasoningStepContentToolOutputItems0
    {
        /// <summary>
        /// The URL of the webpage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The title of the webpage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A brief summary of the webpage content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// A string representing the age of the web search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContentToolOutputItems0" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the webpage.
        /// </param>
        /// <param name="title">
        /// The title of the webpage.
        /// </param>
        /// <param name="snippet">
        /// A brief summary of the webpage content.
        /// </param>
        /// <param name="age">
        /// A string representing the age of the web search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningStepContentToolOutputItems0(
            string? url,
            string? title,
            string? snippet,
            string? age)
        {
            this.Url = url;
            this.Title = title;
            this.Snippet = snippet;
            this.Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningStepContentToolOutputItems0" /> class.
        /// </summary>
        public ReasoningStepContentToolOutputItems0()
        {
        }

    }
}