using System.Collections;
using Xamarin.Forms;

namespace Fluent
{
    public static class ItemsViewExtensions
    {
        public static ItemsView<Cell> ItemsSource(this ItemsView<Cell> cells, IEnumerable source)
        {
            cells.ItemsSource = source;
            return cells;
        }

        public static ItemsView<Cell> ItemTemplate(this ItemsView<Cell> cells, DataTemplate template)
        {
            cells.ItemTemplate = template;
            return cells;
        }
    }
}