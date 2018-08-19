using Xamarin.Forms;

namespace Fluent
{
    public static class BindableObjectExtensions
    {
        public static BindableObject BindingContext(this BindableObject obj, object context)
        {
            obj.BindingContext = context;
            return obj;
        }
    }
}