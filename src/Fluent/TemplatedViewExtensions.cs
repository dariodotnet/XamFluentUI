using Xamarin.Forms;

namespace Fluent
{
    public static class TemplatedViewExtensions
    {
        public static TemplatedView ControlTemplate(this TemplatedView view, ControlTemplate template)
        {
            view.ControlTemplate = template;
            return view;
        }
    }
}