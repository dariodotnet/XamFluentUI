namespace Fluent
{
    using Xamarin.Forms;

    public static class RadioButtonExtensions
    {
        public static RadioButton ImageSource(this RadioButton button, ImageSource source)
        {
            button.ImageSource = source;
            return button;
        }

        public static RadioButton GroupName(this RadioButton button, string group)
        {
            button.GroupName = group;
            return button;
        }

        public static RadioButton Config(this RadioButton button, ImageSource source, string group)
        {
            button.ImageSource = source;
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