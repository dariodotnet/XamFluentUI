using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class SelectableItemViewExtensions
    {
        public static T SelectedItem<T>(this T element, object selected) where T : SelectableItemsView
        {
            element.SelectedItem = selected;
            return element;
        }

        public static T SelectionChangedCommand<T>(this T element, ICommand command) where T : SelectableItemsView
        {
            element.SelectionChangedCommand = command;
            return element;
        }

        public static T SelectionChangedCommand<T>(this T element, ICommand command, object parameter) where T : SelectableItemsView
        {
            element.SelectionChangedCommand = command;
            element.SelectionChangedCommandParameter = parameter;
            return element;
        }

        public static T SelectionChangedCommandParameter<T>(this T element, object parameter) where T : SelectableItemsView
        {
            element.SelectionChangedCommandParameter = parameter;
            return element;
        }

        public static T SelectionMode<T>(this T element, SelectionMode mode) where T : SelectableItemsView
        {
            element.SelectionMode = mode;
            return element;
        }
    }
}