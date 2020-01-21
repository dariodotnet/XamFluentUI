namespace Fluent
{
    using Xamarin.Forms;

    public static class LinearItemsLayoutExtensions
    {
        public static LinearItemsLayout ItemSpacing(this LinearItemsLayout layout, double spacing)
        {
            layout.ItemSpacing = spacing;
            return layout;
        }
    }
}