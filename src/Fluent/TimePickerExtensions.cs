using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class TimePickerExtensions
    {
        public static TimePicker Format(this TimePicker timePicker, string format)
        {
            timePicker.Format = format;
            return timePicker;
        }

        public static TimePicker Time(this TimePicker timePicker, TimeSpan time)
        {
            timePicker.Time = time;
            return timePicker;
        }

        #region TextProperties

        public static TimePicker FontAttributes(this TimePicker timePicker, FontAttributes attributes)
        {
            timePicker.FontAttributes = attributes;
            return timePicker;
        }

        public static TimePicker FontFamily(this TimePicker timePicker, string fontFamily)
        {
            timePicker.FontFamily = fontFamily;
            return timePicker;
        }

        public static TimePicker FontSize(this TimePicker timePicker, double fontSize)
        {
            timePicker.FontSize = fontSize;
            return timePicker;
        }

        public static TimePicker TextColor(this TimePicker timePicker, Color textColor)
        {
            timePicker.TextColor = textColor;
            return timePicker;
        }

        #endregion
    }
}