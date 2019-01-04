using Xamarin.Forms;

namespace Fluent
{
    public static class SetterExtensions
    {
        public static Setter Property(this Setter setter, BindableProperty property)
        {
            setter.Property = property;
            return setter;
        }

        public static Setter Property(this Setter setter, BindableProperty property, object value)
        {
            setter.Property = property;
            setter.Value = value;
            return setter;
        }

        public static Setter Value(this Setter setter, object value)
        {
            setter.Value = value;
            return setter;
        }
    }
}