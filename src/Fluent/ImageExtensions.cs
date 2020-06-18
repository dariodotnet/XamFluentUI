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

        public static Image IsAnimationPlaying(this Image image, bool playing)
        {
            image.IsAnimationPlaying = playing;
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

        //TODO uncomment when properties are available again
        //public static Image Source(this Image image, ImageSource source, ImageSource loading, ImageSource error)
        //{
        //    image.Source = source;
        //    image.LoadingPlaceholder = loading;
        //    image.ErrorPlaceholder = error;
        //    return image;
        //}

        //public static Image LoadingPlaceholder(this Image image, ImageSource loading)
        //{
        //    image.LoadingPlaceholder = loading;
        //    return image;
        //}

        //public static Image ErrorPlaceholder(this Image image, ImageSource error)
        //{
        //    image.ErrorPlaceholder = error;
        //    return image;
        //}

        public static Image Configure(this Image image,
            ImageSource source,
            Aspect aspect = Xamarin.Forms.Aspect.AspectFit,
            bool isAnimationPlaying = false,
            bool isOpaque = true)
        {
            image.Source = source;
            image.Aspect = aspect;
            image.IsAnimationPlaying = isAnimationPlaying;
            image.IsOpaque = isOpaque;
            return image;
        }
    }
}