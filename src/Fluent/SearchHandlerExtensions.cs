namespace Fluent
{
    using Xamarin.Forms;

    public static class SearchHandlerExtensions
    {
        public static SearchHandler BackgroundColor(this SearchHandler search, Color color)
        {
            search.BackgroundColor = color;
            return search;
        }

        public static SearchHandler CancelButtonColor(this SearchHandler search, Color color)
        {
            search.CancelButtonColor = color;
            return search;
        }

        public static SearchHandler FontAttributes(this SearchHandler search, FontAttributes attributes)
        {
            search.FontAttributes = attributes;
            return search;
        }

        public static SearchHandler FontFamily(this SearchHandler search, string fontFamily)
        {
            search.FontFamily = fontFamily;
            return search;
        }

        public static SearchHandler FontSize(this SearchHandler search, double size)
        {
            search.FontSize = size;
            return search;
        }

        public static SearchHandler HorizontalTextAlignment(this SearchHandler search, TextAlignment alignment)
        {
            search.HorizontalTextAlignment = alignment;
            return search;
        }

        public static SearchHandler Keyboard(this SearchHandler search, Keyboard keyboard)
        {
            search.Keyboard = keyboard;
            return search;
        }

        public static SearchHandler PlaceholderColor(this SearchHandler search, Color color)
        {
            search.PlaceholderColor = color;
            return search;
        }

        public static SearchHandler TextColor(this SearchHandler search, Color color)
        {
            search.TextColor = color;
            return search;
        }

        public static SearchHandler TextTransform(this SearchHandler search, TextTransform transform)
        {
            search.TextTransform = transform;
            return search;
        }
    }
}