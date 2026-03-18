
#nullable enable

namespace Reka
{
    /// <summary>
    /// Computational intensity level. "none" is standard, "low" moderate, "high" maximum quality.<br/>
    /// Default Value: none
    /// </summary>
    public enum ParallelThinkingConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParallelThinkingConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParallelThinkingConfigMode value)
        {
            return value switch
            {
                ParallelThinkingConfigMode.None => "none",
                ParallelThinkingConfigMode.Low => "low",
                ParallelThinkingConfigMode.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParallelThinkingConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "none" => ParallelThinkingConfigMode.None,
                "low" => ParallelThinkingConfigMode.Low,
                "high" => ParallelThinkingConfigMode.High,
                _ => null,
            };
        }
    }
}