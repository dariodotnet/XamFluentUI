using Xamarin.Forms;

namespace Fluent
{
    public static class ContentPageExtensions
    {
        public static ContentPage ControlTemplate(this ContentPage page, ControlTemplate template)
        {
            page.ControlTemplate = template;
            return page;
        }
    }
}