using System.Collections;
using System.Windows.Input;
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

        public static T ItemsSource<T>(this T element, IEnumerable source) where T : ItemsView
        {
            element.ItemsSource = source;
            return element;
        }

        public static T AddLogicalChild<T>(this T itemView, Element element) where T : ItemsView
        {
            itemView.AddLogicalChild(element);
            return itemView;
        }

        public static T RemoveLogicalChild<T>(this T itemView, Element element) where T : ItemsView
        {
            itemView.RemoveLogicalChild(element);
            return itemView;
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

        public static ItemsView HorizontalScrollBarVisibility(this ItemsView items, ScrollBarVisibility visibility)
        {
            items.HorizontalScrollBarVisibility = visibility;
            return items;
        }

        public static ItemsView VerticalScrollBarVisibility(this ItemsView items, ScrollBarVisibility visibility)
        {
            items.VerticalScrollBarVisibility = visibility;
            return items;
        }

        public static ItemsView ScrollBarVisibility(this ItemsView items, ScrollBarVisibility visibility)
        {
            items.HorizontalScrollBarVisibility = visibility;
            items.VerticalScrollBarVisibility = visibility;
            return items;
        }

        public static ItemsView ScrollBarVisibility(this ItemsView items, ScrollBarVisibility horizontalVisibility, ScrollBarVisibility verticalVisibility)
        {
            items.HorizontalScrollBarVisibility = horizontalVisibility;
            items.VerticalScrollBarVisibility = verticalVisibility;
            return items;
        }

        public static ItemsView ItemsUpdatingScrollMode(this ItemsView items, ItemsUpdatingScrollMode mode)
        {
            items.ItemsUpdatingScrollMode = mode;
            return items;
        }

        public static ItemsView RemainingItemsThreshold(this ItemsView items, int total)
        {
            items.RemainingItemsThreshold = total;
            return items;
        }

        public static ItemsView RemainingItemsThresholdReachedCommand(this ItemsView items, ICommand command, object commandParameter = null)
        {
            items.RemainingItemsThresholdReachedCommand = command;
            items.RemainingItemsThresholdReachedCommandParameter = commandParameter;
            return items;
        }
    }
}