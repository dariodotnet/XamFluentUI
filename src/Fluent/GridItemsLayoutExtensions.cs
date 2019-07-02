using Xamarin.Forms;

namespace Fluent
{
    public static class GridItemsLayoutExtensions
    {
        public static GridItemsLayout Span(this GridItemsLayout element, int span)
        {
            element.Span = span;
            return element;
        }

        public static GridItemsLayout HorizontalItemSpacing(this GridItemsLayout grid, double spacing)
        {
            grid.HorizontalItemSpacing = spacing;
            return grid;
        }

        public static GridItemsLayout VerticalItemSpacing(this GridItemsLayout grid, double spacing)
        {
            grid.VerticalItemSpacing = spacing;
            return grid;
        }
    }
}