using Xamarin.Forms;

namespace Fluent
{
    public static class LabelExtensions
    {
        public static Label FormattedText(this Label label, FormattedString formattedString)
        {
            label.FormattedText = formattedString;
            return label;
        }

        public static Label LineBreakMode(this Label label, LineBreakMode mode)
        {
            label.LineBreakMode = mode;
            return label;
        }

        public static Label TextAlignment(this Label label, TextAlignment horizontal = default(TextAlignment),
            TextAlignment vertical = default(TextAlignment))
        {
            label.HorizontalTextAlignment = horizontal;
            label.VerticalTextAlignment = vertical;
            return label;
        }

        public static Label MaxLines(this Label label, int maxLines)
        {
            label.MaxLines = maxLines;
            return label;
        }

        public static Label TextDecorations(this Label label, TextDecorations decorations)
        {
            label.TextDecorations = decorations;
            return label;
        }

        #region TextProperties

        public static Label FontAttributes(this Label label, FontAttributes attributes)
        {
            label.FontAttributes = attributes;
            return label;
        }

        public static Label FontFamily(this Label label, string fontFamily)
        {
            label.FontFamily = fontFamily;
            return label;
        }

        public static Label FontSize(this Label label, double fontSize)
        {
            label.FontSize = fontSize;
            return label;
        }

        public static Label Text(this Label label, string text)
        {
            label.Text = text;
            return label;
        }

        public static Label TextColor(this Label label, Color textColor)
        {
            label.TextColor = textColor;
            return label;
        }

        public static Label Text(this Label label, string text, Color textColor = default(Color))
        {
            label.Text = text;
            label.TextColor = textColor;
            return label;
        }

        public static Label CharacterSpacing(this Label label, double spacing)
        {
            label.CharacterSpacing = spacing;
            return label;
        }

        public static Label Padding(this Label label, Thickness padding)
        {
            label.Padding = padding;
            return label;
        }

        public static Label TextType(this Label label, TextType textType)
        {
            label.TextType = textType;
            return label;
        }

        #endregion
    }
}