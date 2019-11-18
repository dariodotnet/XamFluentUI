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
    }
}