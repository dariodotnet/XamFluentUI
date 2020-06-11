namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class LineSegmentExtensions
    {
        public static LineSegment Point(this LineSegment segment, Point point)
        {
            segment.Point = point;
            return segment;
        }
    }
}