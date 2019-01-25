using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class UriImageSourceExtensions
    {
        public static UriImageSource CacheValidity(this UriImageSource source, TimeSpan timeSpan)
        {
            source.CacheValidity = timeSpan;
            return source;
        }

        public static UriImageSource CachingEnabled(this UriImageSource source, bool enabled)
        {
            source.CachingEnabled = enabled;
            return source;
        }

        public static UriImageSource Uri(this UriImageSource source, Uri uri)
        {
            source.Uri = uri;
            return source;
        }

        public static UriImageSource Uri(this UriImageSource source, Uri uri, bool enabled, TimeSpan timeSpan)
        {
            source.Uri = uri;
            source.CachingEnabled = enabled;
            source.CacheValidity = timeSpan;
            return source;
        }

    }
}