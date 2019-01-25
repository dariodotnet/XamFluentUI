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
    }
}