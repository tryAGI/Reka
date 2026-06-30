
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.
    /// </summary>
    public enum ChatCompletionResponseMessageAnnotationsItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionResponseMessageAnnotationsItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseMessageAnnotationsItemsType value)
        {
            return value switch
            {
                ChatCompletionResponseMessageAnnotationsItemsType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseMessageAnnotationsItemsType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => ChatCompletionResponseMessageAnnotationsItemsType.UrlCitation,
                _ => null,
            };
        }
    }
}