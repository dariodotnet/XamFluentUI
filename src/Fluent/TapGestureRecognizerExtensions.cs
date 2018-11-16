using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class TapGestureRecognizerExtensions
    {
        public static TapGestureRecognizer Command(this TapGestureRecognizer tap, ICommand command, object parameter = null)
        {
            tap.Command = command;
            if (parameter != null)
                tap.CommandParameter = parameter;

            return tap;
        }

        public static TapGestureRecognizer NumberOfTapsRequired(this TapGestureRecognizer tap, int taps)
        {
            tap.NumberOfTapsRequired = taps;
            return tap;
        }

        public static TapGestureRecognizer TappedEvent(this TapGestureRecognizer tap, Action<object> action)
        {
            tap.Tapped += (sender, args) => { action.Invoke(args); };
            return tap;
        }

        public static TapGestureRecognizer TappedEvent(this TapGestureRecognizer tap, Action action)
        {
            tap.Tapped += (sender, args) => { action.Invoke(); };
            return tap;
        }
    }
}