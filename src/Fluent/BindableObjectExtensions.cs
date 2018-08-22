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

        public static BindableObject Binding(this BindableObject bindableObject, BindableProperty targetProperty, BindingBase binding)
        {
            bindableObject.SetBinding(targetProperty, binding);
            return bindableObject;
        }
    }
}