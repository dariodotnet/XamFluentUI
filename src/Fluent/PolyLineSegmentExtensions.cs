namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class PolyLineSegmentExtensions
    {
        public static PolyLineSegment Points(this PolyLineSegment segment, PointCollection collection)
        {
            segment.Points = collection;
            return segment;
        }
    }
}