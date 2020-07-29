namespace Fluent
{
    using Xamarin.Forms;

    public static class GradientBrushExtensions
    {
        public static GradientBrush GradientStops(this GradientBrush brush, GradientStopCollection collection)
        {
            brush.GradientStops = collection;
            return brush;
        }
    }
}