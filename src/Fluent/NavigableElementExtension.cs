using Xamarin.Forms;

namespace Fluent
{
    public static class NavigableElementExtension
    {
        public static T Style<T>(this T element, Style style) where T : NavigableElement
        {
            element.Style = style;
            return element;
        }
    }
}