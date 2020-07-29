namespace Fluent
{
    using Xamarin.Forms;

    public static class RadialGradientExtensions
    {
        public static RadialGradientBrush Center(this RadialGradientBrush brush, Point point)
        {
            brush.Center = point;
            return brush;
        }

        public static RadialGradientBrush Radius(this RadialGradientBrush brush, float radius)
        {
            brush.Radius = radius;
            return brush;
        }

        public static RadialGradientBrush Configure(this RadialGradientBrush brush, (Point, float) configuration) =>
            brush.Center(configuration.Item1).Radius(configuration.Item2);
    }
}