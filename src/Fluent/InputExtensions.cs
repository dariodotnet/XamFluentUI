using Xamarin.Forms;

namespace Fluent
{
    public static class InputExtensions
    {
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
    }
}