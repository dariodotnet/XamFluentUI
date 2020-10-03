namespace Fluent
{
    using Xamarin.Forms;

    public static class RadioButtonExtensions
    {
        public static RadioButton BorderColor(this RadioButton button, Color color)
        {
            button.BorderColor = color;
            return button;
        }

        public static RadioButton BorderWidth(this RadioButton button, double width)
        {
            button.BorderWidth = width;
            return button;
        }

        public static RadioButton Border(this RadioButton button, Color color, double width)
        {
            return button.BorderColor(color).BorderWidth(width);
        }

        public static RadioButton CharacterSpacing(this RadioButton button, double spacing)
        {
            button.CharacterSpacing = spacing;
            return button;
        }

        public static RadioButton Content(this RadioButton button, object content)
        {
            button.Content = content;
            return button;
        }

        public static RadioButton CornerRadius(this RadioButton button, int radius)
        {
            button.CornerRadius = radius;
            return button;
        }

        public static RadioButton FontAttributes(this RadioButton button, FontAttributes attributes)
        {
            button.FontAttributes = attributes;
            return button;
        }

        public static RadioButton FontFamily(this RadioButton button, string family)
        {
            button.FontFamily = family;
            return button;
        }

        public static RadioButton FontSize(this RadioButton button, double size)
        {
            button.FontSize = size;
            return button;
        }

        public static RadioButton Font(this RadioButton button, FontAttributes attributes, string family, double size)
        {
            return button.FontAttributes(attributes).FontFamily(family).FontSize(size);
        }

        public static RadioButton TextColor(this RadioButton button, Color color)
        {
            button.TextColor = color;
            return button;
        }

        public static RadioButton TextTransform(this RadioButton button, TextTransform transform)
        {
            button.TextTransform = transform;
            return button;
        }

        public static RadioButton Text(this RadioButton button, Color color, TextTransform transform)
        {
            return button.TextColor(color).TextTransform(transform);
        }

        public static RadioButton Value(this RadioButton button, object value)
        {
            button.Value = value;
            return button;
        }

        public static RadioButton GroupName(this RadioButton button, string group)
        {
            button.GroupName = group;
            return button;
        }

        public static RadioButton IsChecked(this RadioButton button, bool isChecked)
        {
            button.IsChecked = isChecked;
            return button;
        }
    }
}