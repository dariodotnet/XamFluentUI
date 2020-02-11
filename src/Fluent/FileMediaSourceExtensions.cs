namespace Fluent
{
    using Xamarin.Forms;

    public static class FileMediaSourceExtensions
    {
        public static FileMediaSource File(this FileMediaSource source, string file)
        {
            source.File = file;
            return source;
        }
    }
}