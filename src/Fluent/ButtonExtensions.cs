using Xamarin.Forms;

namespace Fluent
{
    public static class ButtonExtensions
    {
        public static Button BorderColor(this Button button, Color color)
        {
            button.BorderColor = color;
            return button;
        }

        public static Button BorderWidth(this Button button, double width)
        {
            button.BorderWidth = width;
            return button;
        }

        public static Button CornerRadius(this Button button, int radius)
        {
            button.CornerRadius = radius;
            return button;
        }

        public static Button ContentLayout(this Button button, Button.ButtonContentLayout layout)
        {
            button.ContentLayout = layout;
            return button;
        }

        public static Button Image(this Button button, FileImageSource image)
        {
            button.Image = image;
            return button;
        }

        #region TextProperties

        public static Button Font(this Button button, Font font)
        {
            button.Font = font;
            return button;
        }

        public static Button FontAttributes(this Button button, FontAttributes attributes)
        {
            button.FontAttributes = attributes;
            return button;
        }

        public static Button FontFamily(this Button button, string fontFamily)
        {
            button.FontFamily = fontFamily;
            return button;
        }

        public static Button FontSize(this Button button, double fontSize)
        {
            button.FontSize = fontSize;
            return button;
        }

        public static Button Text(this Button button, string text, Color textColor = default(Color))
        {
            button.Text = text;
            button.TextColor = textColor;
            return button;
        }

        #endregion
    }
}