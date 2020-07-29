using Xamarin.Forms;

namespace Fluent
{
    public static class NavigationPageExtensions
    {
        public static NavigationPage BarBackgroundColor(this NavigationPage page, Color color)
        {
            page.BarBackgroundColor = color;
            return page;
        }

        public static NavigationPage BarTextColor(this NavigationPage page, Color color)
        {
            page.BarTextColor = color;
            return page;
        }

        public static NavigationPage BarBackground(this NavigationPage page, Brush color)
        {
            page.BarBackground = color;
            return page;
        }
    }
}