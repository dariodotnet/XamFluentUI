namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class LineGeometryExtensions
    {
        public static LineGeometry EndPoint(this LineGeometry line, Point point)
        {
            line.EndPoint = point;
            return line;
        }

        public static LineGeometry StartPoint(this LineGeometry line, Point point)
        {
            line.StartPoint = point;
            return line;
        }

        public static LineGeometry Define(this LineGeometry line, (Point, Point) points)
        {
            return line.StartPoint(points.Item1).EndPoint(points.Item2);
        }
    }
}