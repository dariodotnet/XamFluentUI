using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class SwipeGestureRecognizerExtensions
    {
        public static SwipeGestureRecognizer Command(this SwipeGestureRecognizer swipe, ICommand command, object parameter = null)
        {
            swipe.Command = command;
            if (parameter != null)
                swipe.CommandParameter = parameter;

            return swipe;
        }

        public static SwipeGestureRecognizer Direction(this SwipeGestureRecognizer swipe, SwipeDirection direction)
        {
            swipe.Direction = direction;
            return swipe;
        }

        public static SwipeGestureRecognizer Threshold(this SwipeGestureRecognizer swipe, uint threshold)
        {
            swipe.Threshold = threshold;
            return swipe;
        }

        public static SwipeGestureRecognizer SwipedEvent(this SwipeGestureRecognizer swipe, Action action)
        {
            swipe.Swiped += (sender, args) => { action.Invoke(); };
            return swipe;
        }

        public static SwipeGestureRecognizer SwipedEvent(this SwipeGestureRecognizer swipe, Action<object> action, object parameter)
        {
            swipe.Swiped += (sender, args) => { action.Invoke(parameter); };
            return swipe;
        }
    }
}