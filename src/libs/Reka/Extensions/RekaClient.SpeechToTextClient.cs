using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace Reka;

public partial class RekaClient : Microsoft.Extensions.AI.ISpeechToTextClient
{
    private Microsoft.Extensions.AI.SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? Microsoft.Extensions.AI.ISpeechToTextClient.GetService(Type? serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(Microsoft.Extensions.AI.SpeechToTextClientMetadata)
                ? (_speechMetadata ??= new(nameof(RekaClient), BaseUri))
                : serviceType?.IsInstanceOfType(this) is true ? this :
                null;
    }

    async Task<Microsoft.Extensions.AI.SpeechToTextResponse> Microsoft.Extensions.AI.ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        Microsoft.Extensions.AI.SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as TranscribeOrTranslateRequest
            ?? new TranscribeOrTranslateRequest
            {
                AudioUrl = string.Empty,
                SamplingRate = 16000,
            };

        // Convert stream to base64 data URI if no URL was provided via RawRepresentationFactory
        if (string.IsNullOrEmpty(request.AudioUrl))
        {
            MemoryStream? ms = audioSpeechStream as MemoryStream;
            if (ms is null || ms.Position != 0)
            {
                ms = new MemoryStream();
                await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            }

            byte[] bytes = ms.TryGetBuffer(out var buffer)
                ? buffer.Array![buffer.Offset..(buffer.Offset + buffer.Count)]
                : ms.ToArray();

            request.AudioUrl = $"data:audio/wav;base64,{Convert.ToBase64String(bytes)}";
        }

        var response = await Speech.TranscribeOrTranslateAsync(request, cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        TimeSpan? startTime = null;
        TimeSpan? endTime = null;
        if (response.TranscriptTranslationWithTimestamp is { Count: > 0 } timestamps)
        {
            startTime = TimeSpan.FromSeconds(timestamps[0].Start);
            endTime = TimeSpan.FromSeconds(timestamps[^1].End);
        }

        return new Microsoft.Extensions.AI.SpeechToTextResponse(response.Transcript)
        {
            RawRepresentation = response,
            StartTime = startTime,
            EndTime = endTime,
        };
    }

    async IAsyncEnumerable<Microsoft.Extensions.AI.SpeechToTextResponseUpdate> Microsoft.Extensions.AI.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        Microsoft.Extensions.AI.SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((Microsoft.Extensions.AI.ISpeechToTextClient)this)
            .GetTextAsync(audioSpeechStream, options, cancellationToken)
            .ConfigureAwait(false);

        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}
