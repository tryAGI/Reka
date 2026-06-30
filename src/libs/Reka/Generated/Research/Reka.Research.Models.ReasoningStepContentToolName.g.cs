
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The name of the tool executed.
    /// </summary>
    public enum ReasoningStepContentToolName
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
    public static class ReasoningStepContentToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningStepContentToolName value)
        {
            return value switch
            {
                ReasoningStepContentToolName.Analyze => "analyze",
                ReasoningStepContentToolName.SearchWeb => "search_web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningStepContentToolName? ToEnum(string value)
        {
            return value switch
            {
                "analyze" => ReasoningStepContentToolName.Analyze,
                "search_web" => ReasoningStepContentToolName.SearchWeb,
                _ => null,
            };
        }
    }
}