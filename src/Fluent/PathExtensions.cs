namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class PathExtensions
    {
        public static Path Data(this Path path, Geometry geometry)
        {
            path.Data = geometry;
            return path;
        }

        public static Path RenderTransform(this Path path, Transform transform)
        {
            path.RenderTransform = transform;
            return path;
        }

        public static Path Path(this Path path, Geometry geometry, Transform transform)
        {
            return path.Data(geometry).RenderTransform(transform);
        }
    }
}