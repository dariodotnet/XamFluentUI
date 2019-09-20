namespace Fluent
{
    using Xamarin.Forms;

    public static class StructuredItemsViewExtensions
    {
        public static StructuredItemsView Footer(this StructuredItemsView items, object footer)
        {
            items.Footer = footer;
            return items;
        }

        public static StructuredItemsView FooterTemplate(this StructuredItemsView items, DataTemplate template)
        {
            items.FooterTemplate = template;
            return items;
        }

        public static StructuredItemsView Footer(this StructuredItemsView items, object footer, DataTemplate template)
        {
            items.Footer = footer;
            items.FooterTemplate = template;
            return items;
        }

        public static StructuredItemsView Header(this StructuredItemsView items, object header)
        {
            items.Header = header;
            return items;
        }

        public static StructuredItemsView Header(this StructuredItemsView items, object header, DataTemplate template)
        {
            items.Header = header;
            items.HeaderTemplate = template;
            return items;
        }

        public static StructuredItemsView HeaderTemplate(this StructuredItemsView items, DataTemplate template)
        {
            items.HeaderTemplate = template;
            return items;
        }

        public static StructuredItemsView ItemsLayout(this StructuredItemsView items, IItemsLayout layout)
        {
            items.ItemsLayout = layout;
            return items;
        }
    }
}