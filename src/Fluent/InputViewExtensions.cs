namespace Fluent
{
    using Xamarin.Forms;

    public static class InputViewExtensions
    {
        public static T CharacterSpacing<T>(this T input, double characterSpacing) where T : InputView
        {
            input.CharacterSpacing = characterSpacing;
            return input;
        }

        public static T Placeholder<T>(this T input, string placeholder) where T : InputView
        {
            input.Placeholder = placeholder;
            return input;
        }

        public static T Placeholder<T>(this T input, string placeholder, Color color) where T : InputView
        {
            input.Placeholder = placeholder;
            input.PlaceholderColor = color;
            return input;
        }

        public static T PlaceholderColor<T>(this T input, Color color) where T : InputView
        {
            input.PlaceholderColor = color;
            return input;
        }

        public static T Text<T>(this T input, string text) where T : InputView
        {
            input.Text = text;
            return input;
        }

        public static T Text<T>(this T input, string text, Color color) where T : InputView
        {
            input.Text = text;
            input.TextColor = color;
            return input;
        }

        public static T TextColor<T>(this T input, Color color) where T : InputView
        {
            input.TextColor = color;
            return input;
        }

        public static T IsSpellCheckEnabled<T>(this T input, bool enabled) where T : InputView
        {
            input.IsSpellCheckEnabled = enabled;
            return input;
        }

        public static T Keyboard<T>(this T input, Keyboard keyboard) where T : InputView
        {
            input.Keyboard = keyboard;
            return input;
        }

        public static T MaxLength<T>(this T input, int maxLenght) where T : InputView
        {
            input.MaxLength = maxLenght;
            return input;
        }

        public static T TextTransform<T>(this T input, TextTransform transform) where T : InputView
        {
            input.TextTransform = transform;
            return input;
        }
    }
}