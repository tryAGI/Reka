
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// Fields searchable by the text strategy.
    /// </summary>
    public enum SearchTextField
    {
        /// <summary>
        /// 
        /// </summary>
        Captions,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchTextFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTextField value)
        {
            return value switch
            {
                SearchTextField.Captions => "captions",
                SearchTextField.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTextField? ToEnum(string value)
        {
            return value switch
            {
                "captions" => SearchTextField.Captions,
                "transcript" => SearchTextField.Transcript,
                _ => null,
            };
        }
    }
}