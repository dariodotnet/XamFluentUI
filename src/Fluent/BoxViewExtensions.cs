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
    }
}