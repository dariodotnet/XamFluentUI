namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class RectangleExtensions
    {
        public static Rectangle Radius(this Rectangle rectangle, (double, double) radius)
        {
            rectangle.RadiusX = radius.Item1;
            rectangle.RadiusY = radius.Item2;
            return rectangle;
        }
    }
}