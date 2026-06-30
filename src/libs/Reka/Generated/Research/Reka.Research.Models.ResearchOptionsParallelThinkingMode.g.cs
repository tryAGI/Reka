
#nullable enable

namespace Reka.Research
{
    /// <summary>
    /// The level of additional compute to use for generating the answer. Use "none" for default behavior, "low" for moderate additional compute, or "high" for maximum additional compute and quality.<br/>
    /// Default Value: none
    /// </summary>
    public enum ResearchOptionsParallelThinkingMode
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOptionsParallelThinkingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOptionsParallelThinkingMode value)
        {
            return value switch
            {
                ResearchOptionsParallelThinkingMode.High => "high",
                ResearchOptionsParallelThinkingMode.Low => "low",
                ResearchOptionsParallelThinkingMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOptionsParallelThinkingMode? ToEnum(string value)
        {
            return value switch
            {
                "high" => ResearchOptionsParallelThinkingMode.High,
                "low" => ResearchOptionsParallelThinkingMode.Low,
                "none" => ResearchOptionsParallelThinkingMode.None,
                _ => null,
            };
        }
    }
}