namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class PolyBezierSegmentExtensions
    {
        public static PolyBezierSegment Points(this PolyBezierSegment segment, PointCollection points)
        {
            segment.Points = points;
            return segment;
        }
    }
}