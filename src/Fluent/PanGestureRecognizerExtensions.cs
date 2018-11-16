using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class PanGestureRecognizerExtensions
    {
        public static PanGestureRecognizer TouchPoints(this PanGestureRecognizer pan, int points)
        {
            pan.TouchPoints = points;
            return pan;
        }

        public static PanGestureRecognizer PanUpdatedEvent(this PanGestureRecognizer pan, Action action)
        {
            pan.PanUpdated += (sender, args) => { action.Invoke(); };
            return pan;
        }

        public static PanGestureRecognizer PanUpdatedEvent(this PanGestureRecognizer pan, Action<object> action, object parameter)
        {
            pan.PanUpdated += (sender, args) => { action.Invoke(parameter); };
            return pan;
        }
    }

    public static class PinchGestureRecognizerExtensions
    {
        public static PinchGestureRecognizer PinchUpdatedEvent(this PinchGestureRecognizer pinch, Action action)
        {
            pinch.PinchUpdated += (sender, args) => { action.Invoke(); };
            return pinch;
        }

        public static PinchGestureRecognizer PinchUpdatedEvent(this PinchGestureRecognizer pinch, Action<object> action, object parameter)
        {
            pinch.PinchUpdated += (sender, args) => { action.Invoke(parameter); };
            return pinch;
        }
    }
}