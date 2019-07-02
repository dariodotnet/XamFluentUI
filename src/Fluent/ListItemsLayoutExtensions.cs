using Xamarin.Forms;

namespace Fluent
{
    public static class ListItemsLayoutExtensions
    {
        public static ListItemsLayout ItemsSpacing(this ListItemsLayout layout, double spacing)
        {
            layout.ItemSpacing = spacing;
            return layout;
        }
    }
}