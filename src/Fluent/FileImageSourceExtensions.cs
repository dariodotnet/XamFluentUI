namespace Fluent
{
    using Xamarin.Forms;

    public static class FileImageSourceExtensions
    {
        public static FileImageSource File(this FileImageSource file, string name)
        {
            file.File = name;
            return file;
        }
    }
}