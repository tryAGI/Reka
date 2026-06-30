#nullable enable

namespace Reka.Vision
{
    public partial interface IV2Client
    {
        /// <summary>
        /// Trigger Objects<br/>
        /// Dispatch object detection and tracking on video chunks.<br/>
        /// Known issues:<br/>
        /// - Only detects people (via /person/track). The feature is named "objects"<br/>
        ///   but other BoundingBoxType values (face, text, facecam) are never produced<br/>
        ///   here; filtering get_objects by those types silently returns nothing.<br/>
        /// - person_id is always null in API responses. The tracker assigns integer<br/>
        ///   tracking IDs per chunk, which are converted to UUID strings before DB<br/>
        ///   storage. The API reader calls int() on those UUIDs, which always fails.<br/>
        /// - person_id is chunk-scoped, not video-scoped. The tracker resets IDs at<br/>
        ///   each chunk boundary, so the same person gets a different person_id in<br/>
        ///   every chunk — cross-chunk re-identification does not work.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerObjectsV2VideosVideoIdFeaturesObjectsPostAsync(
            string videoId,

            global::Reka.Vision.ObjectsTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Objects<br/>
        /// Dispatch object detection and tracking on video chunks.<br/>
        /// Known issues:<br/>
        /// - Only detects people (via /person/track). The feature is named "objects"<br/>
        ///   but other BoundingBoxType values (face, text, facecam) are never produced<br/>
        ///   here; filtering get_objects by those types silently returns nothing.<br/>
        /// - person_id is always null in API responses. The tracker assigns integer<br/>
        ///   tracking IDs per chunk, which are converted to UUID strings before DB<br/>
        ///   storage. The API reader calls int() on those UUIDs, which always fails.<br/>
        /// - person_id is chunk-scoped, not video-scoped. The tracker resets IDs at<br/>
        ///   each chunk boundary, so the same person gets a different person_id in<br/>
        ///   every chunk — cross-chunk re-identification does not work.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reka.Vision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.AutoSDKHttpResponse<global::Reka.Vision.FeatureTriggerResponse>> TriggerObjectsV2VideosVideoIdFeaturesObjectsPostAsResponseAsync(
            string videoId,

            global::Reka.Vision.ObjectsTriggerRequest request,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Objects<br/>
        /// Dispatch object detection and tracking on video chunks.<br/>
        /// Known issues:<br/>
        /// - Only detects people (via /person/track). The feature is named "objects"<br/>
        ///   but other BoundingBoxType values (face, text, facecam) are never produced<br/>
        ///   here; filtering get_objects by those types silently returns nothing.<br/>
        /// - person_id is always null in API responses. The tracker assigns integer<br/>
        ///   tracking IDs per chunk, which are converted to UUID strings before DB<br/>
        ///   storage. The API reader calls int() on those UUIDs, which always fails.<br/>
        /// - person_id is chunk-scoped, not video-scoped. The tracker resets IDs at<br/>
        ///   each chunk boundary, so the same person gets a different person_id in<br/>
        ///   every chunk — cross-chunk re-identification does not work.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="personLocalization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Reka.Vision.FeatureTriggerResponse> TriggerObjectsV2VideosVideoIdFeaturesObjectsPostAsync(
            string videoId,
            bool? force = default,
            global::Reka.Vision.PersonLocalizationConfig? personLocalization = default,
            global::Reka.Vision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}