
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChunkerType
    {
        /// <summary>
        /// 
        /// </summary>
        MaxUtility,
        /// <summary>
        /// 
        /// </summary>
        Remote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkerType value)
        {
            return value switch
            {
                ChunkerType.MaxUtility => "max_utility",
                ChunkerType.Remote => "remote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkerType? ToEnum(string value)
        {
            return value switch
            {
                "max_utility" => ChunkerType.MaxUtility,
                "remote" => ChunkerType.Remote,
                _ => null,
            };
        }
    }
}