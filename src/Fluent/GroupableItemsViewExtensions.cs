using Xamarin.Forms;

namespace Fluent
{
    public static class GroupableItemsViewExtensions
    {
        public static GroupableItemsView GroupFooterTemplate(this GroupableItemsView items, DataTemplate template)
        {
            items.GroupFooterTemplate = template;
            return items;
        }

        public static GroupableItemsView GroupHeaderTemplate(this GroupableItemsView items, DataTemplate template)
        {
            items.GroupHeaderTemplate = template;
            return items;
        }

        public static GroupableItemsView GroupHeaderAndFooterTemplate(this GroupableItemsView items, DataTemplate headerTemplate, DataTemplate footerTemplate)
        {
            items.GroupHeaderTemplate = headerTemplate;
            items.FooterTemplate = footerTemplate;
            return items;
        }

        public static GroupableItemsView IsGrouped(this GroupableItemsView items, bool isGrouped)
        {
            items.IsGrouped = isGrouped;
            return items;
        }
    }
}