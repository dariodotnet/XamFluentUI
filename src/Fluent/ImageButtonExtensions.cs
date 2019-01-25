using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class ImageButtonExtensions
    {
        public static ImageButton Aspect(this ImageButton imageButton, Aspect aspect)
        {
            imageButton.Aspect = aspect;
            return imageButton;
        }

        public static ImageButton BorderColor(this ImageButton imageButton, Color color)
        {
            imageButton.BorderColor = color;
            return imageButton;
        }

        public static ImageButton BorderWidth(this ImageButton imageButton, double width)
        {
            imageButton.BorderWidth = width;
            return imageButton;
        }

        public static ImageButton Command(this ImageButton imageButton, ICommand command)
        {
            imageButton.Command = command;
            return imageButton;
        }

        public static ImageButton Command(this ImageButton imageButton, ICommand command, object parameter)
        {
            imageButton.Command = command;
            imageButton.CommandParameter = parameter;
            return imageButton;
        }

        public static ImageButton CommandParameter(this ImageButton imageButton, object parameter)
        {
            imageButton.CommandParameter = parameter;
            return imageButton;
        }

        public static ImageButton CornerRadius(this ImageButton imageButton, int radius)
        {
            imageButton.CornerRadius = radius;
            return imageButton;
        }

        public static ImageButton IsOpaque(this ImageButton imageButton, bool isOpaque)
        {
            imageButton.IsOpaque = isOpaque;
            return imageButton;
        }

        public static ImageButton Padding(this ImageButton imageButton, double uniform)
        {
            imageButton.Padding = new Thickness(uniform);
            return imageButton;
        }

        public static ImageButton Padding(this ImageButton imageButton, double horizontal, double vertical)
        {
            imageButton.Padding = new Thickness(horizontal, vertical);
            return imageButton;
        }

        public static ImageButton Padding(this ImageButton imageButton, double left, double top, double right, double bottom)
        {
            imageButton.Padding = new Thickness(left, top, right, bottom);
            return imageButton;
        }

        public static ImageButton Source(this ImageButton imageButton, ImageSource source)
        {
            imageButton.Source = source;
            return imageButton;
        }
    }
}