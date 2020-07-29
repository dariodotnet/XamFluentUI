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

        public static TabbedPage SelectedTabColor(this TabbedPage page, Color color)
        {
            page.SelectedTabColor = color;
            return page;
        }

        public static TabbedPage UnselectedTabColor(this TabbedPage page, Color color)
        {
            page.UnselectedTabColor = color;
            return page;
        }

        public static TabbedPage Background(this TabbedPage page, Brush brush)
        {
            page.Background = brush;
            return page;
        }
    }
}