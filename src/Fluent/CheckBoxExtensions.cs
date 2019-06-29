namespace Fluent
{
    using Xamarin.Forms;

    public static class CheckBoxExtensions
    {
        public static CheckBox Color(this CheckBox checkBox, Color color)
        {
            checkBox.Color = color;
            return checkBox;
        }

        public static CheckBox IsChecked(this CheckBox checkBox, bool isChecked)
        {
            checkBox.IsChecked = isChecked;
            return checkBox;
        }
    }
}