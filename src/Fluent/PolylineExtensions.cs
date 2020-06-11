namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class PolylineExtensions
    {
        public static Polyline FillRule(this Polyline polyLine, FillRule fillRule)
        {
            polyLine.FillRule = fillRule;
            return polyLine;
        }

        public static Polyline Points(this Polyline polyLine, PointCollection points)
        {
            polyLine.Points = points;
            return polyLine;
        }

        public static Polyline Define(this Polyline polyLine, PointCollection points, FillRule fillRule)
        {
            return polyLine.Points(points).FillRule(fillRule);
        }
    }
}