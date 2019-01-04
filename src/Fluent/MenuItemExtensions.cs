using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class MenuItemExtensions
    {
        public static MenuItem Command(this MenuItem item, ICommand command)
        {
            item.Command = command;
            return item;
        }

        public static MenuItem CommandParameter(this MenuItem item, object parameter)
        {
            item.CommandParameter = parameter;
            return item;
        }

        public static MenuItem Icon(this MenuItem item, FileImageSource source)
        {
            item.Icon = source;
            return item;
        }

        public static MenuItem IsDestructive(this MenuItem item, bool destructive)
        {
            item.IsDestructive = destructive;
            return item;
        }

        public static MenuItem Text(this MenuItem item, string text)
        {
            item.Text = text;
            return item;
        }
    }
}