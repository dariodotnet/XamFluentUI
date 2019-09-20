using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class DatePickerExtensions
    {
        public static DatePicker Date(this DatePicker datePicker, DateTime date)
        {
            datePicker.Date = date;
            return datePicker;
        }

        public static DatePicker Format(this DatePicker datePicker, string format)
        {
            datePicker.Format = format;
            return datePicker;
        }

        public static DatePicker ConfigureDates(this DatePicker datePicker, DateTime minDate, DateTime maxDate)
        {
            datePicker.MinimumDate = minDate;
            datePicker.MaximumDate = maxDate;
            return datePicker;
        }

        #region TextProperties

        public static DatePicker FontAttributes(this DatePicker datePicker, FontAttributes attributes)
        {
            datePicker.FontAttributes = attributes;
            return datePicker;
        }

        public static DatePicker FontFamily(this DatePicker datePicker, string fontFamily)
        {
            datePicker.FontFamily = fontFamily;
            return datePicker;
        }

        public static DatePicker FontSize(this DatePicker datePicker, double fontSize)
        {
            datePicker.FontSize = fontSize;
            return datePicker;
        }

        public static DatePicker TextColor(this DatePicker datePicker, Color textColor)
        {
            datePicker.TextColor = textColor;
            return datePicker;
        }

        public static DatePicker CharacterSpacing(this DatePicker datePicker, double spacing)
        {
            datePicker.CharacterSpacing = spacing;
            return datePicker;
        }

        #endregion
    }
}