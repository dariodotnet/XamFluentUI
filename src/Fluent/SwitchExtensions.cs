using Xamarin.Forms;

namespace Fluent
{
    public static class SwitchExtensions
    {
        public static Switch IsToggled(this Switch control, bool toggled)
        {
            control.IsToggled = toggled;
            return control;
        }

        public static Switch OnColor(this Switch control, Color color)
        {
            control.OnColor = color;
            return control;
        }

        public static Switch ThumbColor(this Switch control, Color color)
        {
            control.ThumbColor = color;
            return control;
        }
    }
}