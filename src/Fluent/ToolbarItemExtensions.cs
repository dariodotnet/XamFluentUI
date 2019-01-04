using Xamarin.Forms;

namespace Fluent
{
    public static class ToolbarItemExtensions
    {
        public static ToolbarItem Order(this ToolbarItem item, ToolbarItemOrder order)
        {
            item.Order = order;
            return item;
        }
        
        public static ToolbarItem Priority(this ToolbarItem item, int priority)
        {
            item.Priority = priority;
            return item;
        }
    }
}