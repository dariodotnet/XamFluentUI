namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class PathGeometryExtensions
    {
        public static PathGeometry Figures(this PathGeometry path, PathFigureCollection figures)
        {
            path.Figures = figures;
            return path;
        }

        public static PathGeometry FillRule(this PathGeometry path, FillRule fillRule)
        {
            path.FillRule = fillRule;
            return path;
        }

        public static PathGeometry Geometry(this PathGeometry path, PathFigureCollection collection, FillRule fillRule)
        {
            return path.Figures(collection).FillRule(fillRule);
        }
    }
}