namespace Fluent
{
    using Xamarin.Forms;

    public static class RadioButtonExtensions
    {
        public static RadioButton ButtonSource(this RadioButton button, ImageSource source)
        {
            button.ButtonSource = source;
            return button;
        }

        public static RadioButton GroupName(this RadioButton button, string group)
        {
            button.GroupName = group;
            return button;
        }

        public static RadioButton Config(this RadioButton button, ImageSource source, string group)
        {
            button.ButtonSource = source;
            button.GroupName = group;
            return button;
        }

        public static RadioButton IsChecked(this RadioButton button, bool isChecked)
        {
            button.IsChecked = isChecked;
            return button;
        }
    }
}