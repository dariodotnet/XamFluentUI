namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class GeometryGroupExtensions
    {
        public static GeometryGroup Children(this GeometryGroup group, GeometryCollection collection)
        {
            group.Children = collection;
            return group;
        }

        public static GeometryGroup FillRule(this GeometryGroup group, FillRule fillRule)
        {
            group.FillRule = fillRule;
            return group;
        }

        public static GeometryGroup Group(this GeometryGroup group, GeometryCollection collection, FillRule rule)
        {
            return group.Children(collection).FillRule(rule);
        }
    }
}