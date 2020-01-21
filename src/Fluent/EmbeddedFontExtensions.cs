namespace Fluent
{
    using System.IO;
    using Xamarin.Forms;

    public static class EmbeddedFontExtensions
    {
        public static EmbeddedFont FontName(this EmbeddedFont font, string name)
        {
            font.FontName = name;
            return font;
        }

        public static EmbeddedFont ResourceStream(this EmbeddedFont font, Stream resource)
        {
            font.ResourceStream = resource;
            return font;
        }
    }
}