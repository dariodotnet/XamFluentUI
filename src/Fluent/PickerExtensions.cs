using Xamarin.Forms;

namespace Fluent
{
    public static class PickerExtensions
    {
        public static Picker Title(this Picker picker, string title)
        {
            picker.Title = title;
            return picker;
        }

        #region TextProperties

        public static Picker FontAttributes(this Picker picker, FontAttributes attributes)
        {
            picker.FontAttributes = attributes;
            return picker;
        }

        public static Picker FontFamily(this Picker picker, string fontFamily)
        {
            picker.FontFamily = fontFamily;
            return picker;
        }

        public static Picker FontSize(this Picker picker, double fontSize)
        {
            picker.FontSize = fontSize;
            return picker;
        }

        public static Picker TextColor(this Picker picker, Color textColor)
        {
            picker.TextColor = textColor;
            return picker;
        }

        #endregion
    }
}