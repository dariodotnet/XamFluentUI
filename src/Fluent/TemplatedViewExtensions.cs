using Xamarin.Forms;

namespace Fluent
{
    public static class TemplatedViewExtensions
    {
        public static T ControlTemplate<T>(this T view, ControlTemplate template) where T : TemplatedView
        {
            view.ControlTemplate = template;
            return view;
        }
    }
}