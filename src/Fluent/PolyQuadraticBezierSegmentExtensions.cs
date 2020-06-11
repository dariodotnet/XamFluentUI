namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class PolyQuadraticBezierSegmentExtensions
    {
        public static PolyQuadraticBezierSegment Points(this PolyQuadraticBezierSegment segment, PointCollection collection)
        {
            segment.Points = collection;
            return segment;
        }
    }
}