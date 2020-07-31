namespace Fluent
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public static class DragGestureRecognizerExtensions
    {
        public static DragGestureRecognizer CanDrag(this DragGestureRecognizer drag, bool canDrag)
        {
            drag.CanDrag = canDrag;
            return drag;
        }

        public static DragGestureRecognizer DragStartingCommand(this DragGestureRecognizer drag, ICommand command)
        {
            drag.DragStartingCommand = command;
            return drag;
        }

        public static DragGestureRecognizer DragStartingCommandParameter(this DragGestureRecognizer drag, object parameter)
        {
            drag.DragStartingCommandParameter = parameter;
            return drag;
        }

        public static DragGestureRecognizer DragStartingCommand(this DragGestureRecognizer drag, ICommand command, object parameter)
        {
            return drag.DragStartingCommand(command).DragStartingCommandParameter(parameter);
        }

        public static DragGestureRecognizer DropCompletedCommand(this DragGestureRecognizer drag, ICommand command)
        {
            drag.DropCompletedCommand = command;
            return drag;
        }

        public static DragGestureRecognizer DropCompletedCommandParameter(this DragGestureRecognizer drag, object parameter)
        {
            drag.DropCompletedCommandParameter = parameter;
            return drag;
        }

        public static DragGestureRecognizer DropCompletedCommand(this DragGestureRecognizer drag, ICommand command, object parameter)
        {
            return drag.DropCompletedCommand(command).DropCompletedCommandParameter(parameter);
        }
    }
}