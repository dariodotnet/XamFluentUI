namespace Fluent
{
    using Xamarin.Forms;

    public static class SolidColorBrushExtensions
    {
        public static SolidColorBrush Color(this SolidColorBrush solid, Color color)
        {
            solid.Color = color;
            return solid;
        }
    }
}