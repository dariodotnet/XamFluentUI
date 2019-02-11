using Xamarin.Forms;

namespace Fluent
{
    public static class FontImageSourceExtensions
    {
        public static FontImageSource Color(this FontImageSource image, Color color)
        {
            image.Color = color;
            return image;
        }

        public static FontImageSource FontFamily(this FontImageSource image, string fontFamily)
        {
            image.FontFamily = fontFamily;
            return image;
        }

        public static FontImageSource Glyph(this FontImageSource image, string glyph)
        {
            image.Glyph = glyph;
            return image;
        }

        public static FontImageSource Size(this FontImageSource image, double size)
        {
            image.Size = size;
            return image;
        }

        public static FontImageSource Configure(this FontImageSource image, Color color, string fontFamily, string glyph, double size)
        {
            image.Color = color;
            image.FontFamily = fontFamily;
            image.Glyph = glyph;
            image.Size = size;
            return image;
        }
    }
}