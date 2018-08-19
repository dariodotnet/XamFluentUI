using Xamarin.Forms;

namespace Fluent
{
    public static class ListViewExtensions
    {
        public static ListView Footer(this ListView list, object footer)
        {
            list.Footer = footer;
            return list;
        }

        public static ListView FooterTemplate(this ListView list, DataTemplate template)
        {
            list.FooterTemplate = template;
            return list;
        }

        public static ListView Header(this ListView list, object header)
        {
            list.Header = header;
            return list;
        }

        public static ListView HeaderTemplate(this ListView list, DataTemplate template)
        {
            list.HeaderTemplate = template;
            return list;
        }

        public static ListView IsGroupingEnabled(this ListView listView, bool enabled)
        {
            listView.IsGroupingEnabled = enabled;
            return listView;
        }

        public static ListView IsPullToRefreshEnabled(this ListView listView, bool enabled)
        {
            listView.IsPullToRefreshEnabled = enabled;
            return listView;
        }

        public static ListView RowHeight(this ListView listView, int height)
        {
            listView.RowHeight = height;
            return listView;
        }

        public static ListView SelectionMode(this ListView listView, ListViewSelectionMode mode)
        {
            listView.SelectionMode = mode;
            return listView;
        }

        public static ListView SeparatorColor(this ListView listView, Color color)
        {
            listView.SeparatorColor = color;
            return listView;
        }

        public static ListView SeparatorVisibility(this ListView listView, SeparatorVisibility visibility)
        {
            listView.SeparatorVisibility = visibility;
            return listView;
        }
    }
}