using Xamarin.Forms;

namespace Fluent
{
    public static class BoxViewExtensions
    {
        public static BoxView Color(this BoxView box, Color color)
        {
            box.Color = color;
            return box;
        }

        public static BoxView CornerRadius(this BoxView box, CornerRadius radius)
        {
            box.CornerRadius = radius;
            return box;
        }
    }
}