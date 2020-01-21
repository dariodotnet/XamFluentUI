namespace Fluent
{
    using Xamarin.Forms;

    public static class TemplatedPageExtensions
    {
        public static T ControlTemplate<T>(this T page, ControlTemplate template) where T : TemplatedPage
        {
            page.ControlTemplate = template;
            return page;
        }
    }
}