
#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public enum Feature
    {
        /// <summary>
        /// 
        /// </summary>
        AudioEvents,
        /// <summary>
        /// 
        /// </summary>
        Captions,
        /// <summary>
        /// 
        /// </summary>
        Chapters,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Objects,
        /// <summary>
        /// 
        /// </summary>
        ReelCaptions,
        /// <summary>
        /// 
        /// </summary>
        Scenes,
        /// <summary>
        /// 
        /// </summary>
        Thumbnails,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Feature value)
        {
            return value switch
            {
                Feature.AudioEvents => "audio_events",
                Feature.Captions => "captions",
                Feature.Chapters => "chapters",
                Feature.Embeddings => "embeddings",
                Feature.Objects => "objects",
                Feature.ReelCaptions => "reel_captions",
                Feature.Scenes => "scenes",
                Feature.Thumbnails => "thumbnails",
                Feature.Transcript => "transcript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Feature? ToEnum(string value)
        {
            return value switch
            {
                "audio_events" => Feature.AudioEvents,
                "captions" => Feature.Captions,
                "chapters" => Feature.Chapters,
                "embeddings" => Feature.Embeddings,
                "objects" => Feature.Objects,
                "reel_captions" => Feature.ReelCaptions,
                "scenes" => Feature.Scenes,
                "thumbnails" => Feature.Thumbnails,
                "transcript" => Feature.Transcript,
                _ => null,
            };
        }
    }
}