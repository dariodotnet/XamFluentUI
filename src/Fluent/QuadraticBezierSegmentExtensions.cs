namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class QuadraticBezierSegmentExtensions
    {
        public static QuadraticBezierSegment Points(this QuadraticBezierSegment segment, (Point, Point) points)
        {
            segment.Point1 = points.Item1;
            segment.Point2 = points.Item2;
            return segment;
        }
    }
}