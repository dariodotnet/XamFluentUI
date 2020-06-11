namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class ArcSegmentExtensions
    {
        public static ArcSegment IsLargeArc(this ArcSegment arc, bool isLargeArc)
        {
            arc.IsLargeArc = isLargeArc;
            return arc;
        }

        public static ArcSegment Point(this ArcSegment arc, Point point)
        {
            arc.Point = point;
            return arc;
        }

        public static ArcSegment RotationAngle(this ArcSegment arc, double rotationAngle)
        {
            arc.RotationAngle = rotationAngle;
            return arc;
        }

        public static ArcSegment Size(this ArcSegment arc, Size size)
        {
            arc.Size = size;
            return arc;
        }

        public static ArcSegment SweepDirection(this ArcSegment arc, SweepDirection sweepDirection)
        {
            arc.SweepDirection = sweepDirection;
            return arc;
        }

        public static ArcSegment Arc(this ArcSegment arc, Point point, Size size, double rotationAngle, SweepDirection sweepDirection, bool isLargeArc)
        {
            arc.Point = point;
            arc.Size = size;
            arc.RotationAngle = rotationAngle;
            arc.SweepDirection = sweepDirection;
            arc.IsLargeArc = isLargeArc;
            return arc;
        }
    }
}