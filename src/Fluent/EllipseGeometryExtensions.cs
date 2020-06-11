namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class EllipseGeometryExtensions
    {
        public static EllipseGeometry Center(this EllipseGeometry ellipse, Point center)
        {
            ellipse.Center = center;
            return ellipse;
        }

        public static EllipseGeometry Radius(this EllipseGeometry ellipse, (double, double) radius)
        {
            ellipse.RadiusX = radius.Item1;
            ellipse.RadiusY = radius.Item2;
            return ellipse;
        }

        public static EllipseGeometry Ellipse(this EllipseGeometry ellipse, Point center, (double, double) radius)
        {
            return ellipse.Center(center).Radius(radius);
        }
    }
}