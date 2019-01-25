using System.Collections;
using Xamarin.Forms;

namespace Fluent
{
    public static class ItemsViewExtensions
    {
        public static T EmptyView<T>(this T element, object empty) where T : ItemsView
        {
            element.EmptyView = empty;
            return element;
        }

        public static T EmptyViewTemplate<T>(this T element, DataTemplate template) where T : ItemsView
        {
            element.EmptyViewTemplate = template;
            return element;
        }

        public static T ItemsLayout<T>(this T element, ItemsLayout layout) where T : ItemsView
        {
            element.ItemsLayout = layout;
            return element;
        }

        public static T ItemsSource<T>(this T element, IEnumerable source) where T : ItemsView
        {
            element.ItemsSource = source;
            return element;
        }

        public static T ItemTemplate<T>(this T element, DataTemplate template) where T : ItemsView
        {
            element.ItemTemplate = template;
            return element;
        }

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