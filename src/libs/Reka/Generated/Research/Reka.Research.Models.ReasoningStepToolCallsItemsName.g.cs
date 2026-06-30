
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The name of the tool that was called.
    /// </summary>
    public enum ReasoningStepToolCallsItemsName
    {
        /// <summary>
        /// 
        /// </summary>
        Analyze,
        /// <summary>
        /// 
        /// </summary>
        SearchWeb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningStepToolCallsItemsNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningStepToolCallsItemsName value)
        {
            return value switch
            {
                ReasoningStepToolCallsItemsName.Analyze => "analyze",
                ReasoningStepToolCallsItemsName.SearchWeb => "search_web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningStepToolCallsItemsName? ToEnum(string value)
        {
            return value switch
            {
                "analyze" => ReasoningStepToolCallsItemsName.Analyze,
                "search_web" => ReasoningStepToolCallsItemsName.SearchWeb,
                _ => null,
            };
        }
    }
}