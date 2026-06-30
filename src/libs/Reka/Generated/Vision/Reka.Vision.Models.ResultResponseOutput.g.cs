#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Reka.Vision
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultResponseOutput : global::System.IEquatable<ResultResponseOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.ImageToVideoOutput? ImageToVideoOutput { get; init; }
#else
        public global::Reka.Vision.ImageToVideoOutput? ImageToVideoOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToVideoOutput))]
#endif
        public bool IsImageToVideoOutput => ImageToVideoOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageToVideoOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.ImageToVideoOutput? value)
        {
            value = ImageToVideoOutput;
            return IsImageToVideoOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.ImageToVideoOutput PickImageToVideoOutput() => IsImageToVideoOutput
            ? ImageToVideoOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageToVideoOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.TextToImageOutput? TextToImageOutput { get; init; }
#else
        public global::Reka.Vision.TextToImageOutput? TextToImageOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToImageOutput))]
#endif
        public bool IsTextToImageOutput => TextToImageOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToImageOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.TextToImageOutput? value)
        {
            value = TextToImageOutput;
            return IsTextToImageOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.TextToImageOutput PickTextToImageOutput() => IsTextToImageOutput
            ? TextToImageOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToImageOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.TextToSpeechOutput? TextToSpeechOutput { get; init; }
#else
        public global::Reka.Vision.TextToSpeechOutput? TextToSpeechOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeechOutput))]
#endif
        public bool IsTextToSpeechOutput => TextToSpeechOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToSpeechOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.TextToSpeechOutput? value)
        {
            value = TextToSpeechOutput;
            return IsTextToSpeechOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.TextToSpeechOutput PickTextToSpeechOutput() => IsTextToSpeechOutput
            ? TextToSpeechOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToSpeechOutput' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Reka.Vision.ImageToBboxOutput? ImageToBboxOutput { get; init; }
#else
        public global::Reka.Vision.ImageToBboxOutput? ImageToBboxOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageToBboxOutput))]
#endif
        public bool IsImageToBboxOutput => ImageToBboxOutput != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageToBboxOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Reka.Vision.ImageToBboxOutput? value)
        {
            value = ImageToBboxOutput;
            return IsImageToBboxOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Reka.Vision.ImageToBboxOutput PickImageToBboxOutput() => IsImageToBboxOutput
            ? ImageToBboxOutput!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageToBboxOutput' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultResponseOutput(global::Reka.Vision.ImageToVideoOutput value) => new ResultResponseOutput((global::Reka.Vision.ImageToVideoOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.ImageToVideoOutput?(ResultResponseOutput @this) => @this.ImageToVideoOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResultResponseOutput(global::Reka.Vision.ImageToVideoOutput? value)
        {
            ImageToVideoOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultResponseOutput FromImageToVideoOutput(global::Reka.Vision.ImageToVideoOutput? value) => new ResultResponseOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultResponseOutput(global::Reka.Vision.TextToImageOutput value) => new ResultResponseOutput((global::Reka.Vision.TextToImageOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.TextToImageOutput?(ResultResponseOutput @this) => @this.TextToImageOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResultResponseOutput(global::Reka.Vision.TextToImageOutput? value)
        {
            TextToImageOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultResponseOutput FromTextToImageOutput(global::Reka.Vision.TextToImageOutput? value) => new ResultResponseOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultResponseOutput(global::Reka.Vision.TextToSpeechOutput value) => new ResultResponseOutput((global::Reka.Vision.TextToSpeechOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.TextToSpeechOutput?(ResultResponseOutput @this) => @this.TextToSpeechOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResultResponseOutput(global::Reka.Vision.TextToSpeechOutput? value)
        {
            TextToSpeechOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultResponseOutput FromTextToSpeechOutput(global::Reka.Vision.TextToSpeechOutput? value) => new ResultResponseOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultResponseOutput(global::Reka.Vision.ImageToBboxOutput value) => new ResultResponseOutput((global::Reka.Vision.ImageToBboxOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Reka.Vision.ImageToBboxOutput?(ResultResponseOutput @this) => @this.ImageToBboxOutput;

        /// <summary>
        /// 
        /// </summary>
        public ResultResponseOutput(global::Reka.Vision.ImageToBboxOutput? value)
        {
            ImageToBboxOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultResponseOutput FromImageToBboxOutput(global::Reka.Vision.ImageToBboxOutput? value) => new ResultResponseOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultResponseOutput(
            global::Reka.Vision.ImageToVideoOutput? imageToVideoOutput,
            global::Reka.Vision.TextToImageOutput? textToImageOutput,
            global::Reka.Vision.TextToSpeechOutput? textToSpeechOutput,
            global::Reka.Vision.ImageToBboxOutput? imageToBboxOutput
            )
        {
            ImageToVideoOutput = imageToVideoOutput;
            TextToImageOutput = textToImageOutput;
            TextToSpeechOutput = textToSpeechOutput;
            ImageToBboxOutput = imageToBboxOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageToBboxOutput as object ??
            TextToSpeechOutput as object ??
            TextToImageOutput as object ??
            ImageToVideoOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImageToVideoOutput?.ToString() ??
            TextToImageOutput?.ToString() ??
            TextToSpeechOutput?.ToString() ??
            ImageToBboxOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImageToVideoOutput && !IsTextToImageOutput && !IsTextToSpeechOutput && !IsImageToBboxOutput || !IsImageToVideoOutput && IsTextToImageOutput && !IsTextToSpeechOutput && !IsImageToBboxOutput || !IsImageToVideoOutput && !IsTextToImageOutput && IsTextToSpeechOutput && !IsImageToBboxOutput || !IsImageToVideoOutput && !IsTextToImageOutput && !IsTextToSpeechOutput && IsImageToBboxOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Reka.Vision.ImageToVideoOutput, TResult>? imageToVideoOutput = null,
            global::System.Func<global::Reka.Vision.TextToImageOutput, TResult>? textToImageOutput = null,
            global::System.Func<global::Reka.Vision.TextToSpeechOutput, TResult>? textToSpeechOutput = null,
            global::System.Func<global::Reka.Vision.ImageToBboxOutput, TResult>? imageToBboxOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToVideoOutput && imageToVideoOutput != null)
            {
                return imageToVideoOutput(ImageToVideoOutput!);
            }
            else if (IsTextToImageOutput && textToImageOutput != null)
            {
                return textToImageOutput(TextToImageOutput!);
            }
            else if (IsTextToSpeechOutput && textToSpeechOutput != null)
            {
                return textToSpeechOutput(TextToSpeechOutput!);
            }
            else if (IsImageToBboxOutput && imageToBboxOutput != null)
            {
                return imageToBboxOutput(ImageToBboxOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Reka.Vision.ImageToVideoOutput>? imageToVideoOutput = null,

            global::System.Action<global::Reka.Vision.TextToImageOutput>? textToImageOutput = null,

            global::System.Action<global::Reka.Vision.TextToSpeechOutput>? textToSpeechOutput = null,

            global::System.Action<global::Reka.Vision.ImageToBboxOutput>? imageToBboxOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToVideoOutput)
            {
                imageToVideoOutput?.Invoke(ImageToVideoOutput!);
            }
            else if (IsTextToImageOutput)
            {
                textToImageOutput?.Invoke(TextToImageOutput!);
            }
            else if (IsTextToSpeechOutput)
            {
                textToSpeechOutput?.Invoke(TextToSpeechOutput!);
            }
            else if (IsImageToBboxOutput)
            {
                imageToBboxOutput?.Invoke(ImageToBboxOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Reka.Vision.ImageToVideoOutput>? imageToVideoOutput = null,
            global::System.Action<global::Reka.Vision.TextToImageOutput>? textToImageOutput = null,
            global::System.Action<global::Reka.Vision.TextToSpeechOutput>? textToSpeechOutput = null,
            global::System.Action<global::Reka.Vision.ImageToBboxOutput>? imageToBboxOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImageToVideoOutput)
            {
                imageToVideoOutput?.Invoke(ImageToVideoOutput!);
            }
            else if (IsTextToImageOutput)
            {
                textToImageOutput?.Invoke(TextToImageOutput!);
            }
            else if (IsTextToSpeechOutput)
            {
                textToSpeechOutput?.Invoke(TextToSpeechOutput!);
            }
            else if (IsImageToBboxOutput)
            {
                imageToBboxOutput?.Invoke(ImageToBboxOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageToVideoOutput,
                typeof(global::Reka.Vision.ImageToVideoOutput),
                TextToImageOutput,
                typeof(global::Reka.Vision.TextToImageOutput),
                TextToSpeechOutput,
                typeof(global::Reka.Vision.TextToSpeechOutput),
                ImageToBboxOutput,
                typeof(global::Reka.Vision.ImageToBboxOutput),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResultResponseOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.ImageToVideoOutput?>.Default.Equals(ImageToVideoOutput, other.ImageToVideoOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.TextToImageOutput?>.Default.Equals(TextToImageOutput, other.TextToImageOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.TextToSpeechOutput?>.Default.Equals(TextToSpeechOutput, other.TextToSpeechOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Reka.Vision.ImageToBboxOutput?>.Default.Equals(ImageToBboxOutput, other.ImageToBboxOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultResponseOutput obj1, ResultResponseOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultResponseOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultResponseOutput obj1, ResultResponseOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultResponseOutput o && Equals(o);
        }
    }
}
