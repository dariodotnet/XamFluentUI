namespace Fluent
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public static class DropGestureRecognizerExtensions
    {
        public static DropGestureRecognizer AllowDrop(this DropGestureRecognizer drop, bool allow)
        {
            drop.AllowDrop = allow;
            return drop;
        }

        public static DropGestureRecognizer DragOverCommand(this DropGestureRecognizer drop, ICommand command)
        {
            drop.DragOverCommand = command;
            return drop;
        }

        public static DropGestureRecognizer DragOverCommandParameter(this DropGestureRecognizer drop, object parameter)
        {
            drop.DragOverCommandParameter = parameter;
            return drop;
        }

        public static DropGestureRecognizer DragOverCommand(this DropGestureRecognizer drop, ICommand command, object parameter)
        {
            return drop.DragOverCommand(command).DragOverCommandParameter(parameter);
        }

        public static DropGestureRecognizer DragLeaveCommand(this DropGestureRecognizer drop, ICommand command)
        {
            drop.DragLeaveCommand = command;
            return drop;
        }

        public static DropGestureRecognizer DragLeaveCommandParameter(this DropGestureRecognizer drop, object parameter)
        {
            drop.DragLeaveCommandParameter = parameter;
            return drop;
        }

        public static DropGestureRecognizer DragLeaveCommand(this DropGestureRecognizer drop, ICommand command, object parameter)
        {
            return drop.DragLeaveCommand(command).DragLeaveCommandParameter(parameter);
        }

        public static DropGestureRecognizer DropCommand(this DropGestureRecognizer drop, ICommand command)
        {
            drop.DropCommand = command;
            return drop;
        }

        public static DropGestureRecognizer DropCommandParameter(this DropGestureRecognizer drop, object parameter)
        {
            drop.DropCommandParameter = parameter;
            return drop;
        }

        public static DropGestureRecognizer DropCommand(this DropGestureRecognizer drop, ICommand command, object parameter)
        {
            return drop.DropCommand(command).DropCommandParameter(parameter);
        }
    }
}