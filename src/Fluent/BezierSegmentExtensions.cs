namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class BezierSegmentExtensions
    {
        public static BezierSegment Bezier(this BezierSegment segment, (Point, Point, Point) points)
        {
            segment.Point1 = points.Item1;
            segment.Point2 = points.Item2;
            segment.Point3 = points.Item3;
            return segment;
        }
    }
}