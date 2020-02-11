namespace Fluent
{
    using System;
    using Xamarin.Forms;

    public static class UriMediaSourceExtensions
    {
        public static UriMediaSource Uri(this UriMediaSource source, Uri uri)
        {
            source.Uri = uri;
            return source;
        }
    }
}