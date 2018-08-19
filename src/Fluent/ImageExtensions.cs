using Xamarin.Forms;

namespace Fluent
{
    public static class ImageExtensions
    {
        public static Image Aspect(this Image image, Aspect aspect)
        {
            image.Aspect = aspect;
            return image;
        }
        
        public static Image IsOpaque(this Image image, bool opaque)
        {
            image.IsOpaque = opaque;
            return image;
        }
        
        public static Image Source(this Image image, ImageSource source)
        {
            image.Source = source;
            return image;
        }
    }
}