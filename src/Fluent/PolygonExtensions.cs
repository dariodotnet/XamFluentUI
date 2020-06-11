namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class PolygonExtensions
    {
        public static Polygon FillRule(this Polygon polygon, FillRule fillRule)
        {
            polygon.FillRule = fillRule;
            return polygon;
        }

        public static Polygon Points(this Polygon polygon, PointCollection points)
        {
            polygon.Points = points;
            return polygon;
        }

        public static Polygon Polygon(this Polygon polygon, PointCollection points, FillRule fillRule)
        {
            return polygon.Points(points).FillRule(fillRule);
        }
    }
}