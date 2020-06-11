namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class PathFigureExtensions
    {
        public static PathFigure IsClosed(this PathFigure path, bool isClosed)
        {
            path.IsClosed = isClosed;
            return path;
        }

        public static PathFigure IsFilled(this PathFigure path, bool isFilled)
        {
            path.IsFilled = isFilled;
            return path;
        }

        public static PathFigure Segments(this PathFigure path, PathSegmentCollection collection)
        {
            path.Segments = collection;
            return path;
        }

        public static PathFigure StartPoint(this PathFigure path, Point point)
        {
            path.StartPoint = point;
            return path;
        }

        public static PathFigure Figure(this PathFigure path, Point startPoint, PathSegmentCollection collection,
            bool isFilled, bool isClosed)
        {
            return path.StartPoint(startPoint).Segments(collection).IsFilled(isFilled).IsClosed(isClosed);
        }
    }
}