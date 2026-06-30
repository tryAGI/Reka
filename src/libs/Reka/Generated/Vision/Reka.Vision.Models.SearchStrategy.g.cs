
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Semantic,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStrategy value)
        {
            return value switch
            {
                SearchStrategy.Semantic => "semantic",
                SearchStrategy.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStrategy? ToEnum(string value)
        {
            return value switch
            {
                "semantic" => SearchStrategy.Semantic,
                "text" => SearchStrategy.Text,
                _ => null,
            };
        }
    }
}