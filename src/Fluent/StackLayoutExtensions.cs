using Xamarin.Forms;

namespace Fluent
{
    public static class StackLayoutExtensions
    {
        public static StackLayout Orientation(this StackLayout layout, StackOrientation orientation)
        {
            layout.Orientation = orientation;
            return layout;
        }

        public static StackLayout Spacing(this StackLayout layout, double spacing)
        {
            layout.Spacing = spacing;
            return layout;
        }
    }
}