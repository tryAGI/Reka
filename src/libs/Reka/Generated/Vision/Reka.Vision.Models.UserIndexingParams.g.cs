
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// User-facing indexing parameters enum for API responses
    /// </summary>
    public enum UserIndexingParams
    {
        /// <summary>
        /// 
        /// </summary>
        FastSearch,
        /// <summary>
        /// 
        /// </summary>
        Qa,
        /// <summary>
        /// 
        /// </summary>
        QaAndSearch,
        /// <summary>
        /// 
        /// </summary>
        Reels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserIndexingParamsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserIndexingParams value)
        {
            return value switch
            {
                UserIndexingParams.FastSearch => "fast_search",
                UserIndexingParams.Qa => "qa",
                UserIndexingParams.QaAndSearch => "qa_and_search",
                UserIndexingParams.Reels => "reels",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserIndexingParams? ToEnum(string value)
        {
            return value switch
            {
                "fast_search" => UserIndexingParams.FastSearch,
                "qa" => UserIndexingParams.Qa,
                "qa_and_search" => UserIndexingParams.QaAndSearch,
                "reels" => UserIndexingParams.Reels,
                _ => null,
            };
        }
    }
}