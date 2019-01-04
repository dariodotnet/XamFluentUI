using Xamarin.Forms;

namespace Fluent
{
    public static class TabbedPageExtensions
    {
        public static TabbedPage BarBackgroundColor(this TabbedPage page, Color color)
        {
            page.BarBackgroundColor = color;
            return page;
        }

        public static TabbedPage BarTextColor(this TabbedPage page, Color color)
        {
            page.BarTextColor = color;
            return page;
        }
    }
}