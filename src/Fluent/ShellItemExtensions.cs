using Xamarin.Forms;

namespace Fluent
{
    public static class ShellItemExtensions
    {
        public static T CurrentItem<T>(this T shell, ShellSection section) where T : ShellItem
        {
            shell.CurrentItem = section;
            return shell;
        }
    }
}