namespace Fluent
{
    using System;
    using Xamarin.Forms;

    public static class MediaElementExtensions
    {
        public static MediaElement Aspect(this MediaElement element, Aspect aspect)
        {
            element.Aspect = aspect;
            return element;
        }

        public static MediaElement AutoPlay(this MediaElement element, bool autoPlay)
        {
            element.AutoPlay = autoPlay;
            return element;
        }

        public static MediaElement IsLooping(this MediaElement element, bool isLooping)
        {
            element.IsLooping = isLooping;
            return element;
        }

        public static MediaElement KeepScreenOn(this MediaElement element, bool keepScreenOn)
        {
            element.KeepScreenOn = keepScreenOn;
            return element;
        }

        public static MediaElement Position(this MediaElement element, TimeSpan position)
        {
            element.Position = position;
            return element;
        }

        public static MediaElement ShowsPlaybackControls(this MediaElement element, bool showsPlaybackControls)
        {
            element.ShowsPlaybackControls = showsPlaybackControls;
            return element;
        }

        public static MediaElement Source(this MediaElement element, MediaSource source)
        {
            element.Source = source;
            return element;
        }

        public static MediaElement Volume(this MediaElement element, double volume)
        {
            element.Volume = volume;
            return element;
        }
    }
}