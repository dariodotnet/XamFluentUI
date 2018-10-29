using Xamarin.Forms;

namespace Fluent
{
    public static class SpanExtensions
    {
        public static Span BackgroundColor(this Span span, Color color)
        {
            span.BackgroundColor = color;
            return span;
        }

        public static Span Style(this Span span, Style style)
        {
            span.Style = style;
            return span;
        }

        public static Span ForegroundColor(this Span span, Color color)
        {
            span.ForegroundColor = color;
            return span;
        }

        public static Span LineHeight(this Span span, double height)
        {
            span.LineHeight = height;
            return span;
        }

        public static Span TextDecorations(this Span span, TextDecorations decorations)
        {
            span.TextDecorations = decorations;
            return span;
        }

        #region TextProperties

        public static Span FontAttributes(this Span span, FontAttributes attributes)
        {
            span.FontAttributes = attributes;
            return span;
        }

        public static Span FontFamily(this Span span, string fontFamily)
        {
            span.FontFamily = fontFamily;
            return span;
        }

        public static Span FontSize(this Span span, double fontSize)
        {
            span.FontSize = fontSize;
            return span;
        }

        public static Span Text(this Span span, string text, Color textColor)
        {
            span.Text = text;
            span.TextColor = textColor;
            return span;
        }

        #endregion
    }
}