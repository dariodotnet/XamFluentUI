namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class TransformGroupExtensions
    {
        public static TransformGroup Children(this TransformGroup group, TransformCollection collection)
        {
            group.Children = collection;
            return group;
        }
    }
}