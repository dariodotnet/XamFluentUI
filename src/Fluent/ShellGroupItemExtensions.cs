using Xamarin.Forms;

namespace Fluent
{
    public static class ShellGroupItemExtensions
    {
        public static T FlyoutDisplayOptions<T>(this T shell, FlyoutDisplayOptions options) where T : ShellGroupItem
        {
            shell.FlyoutDisplayOptions = options;
            return shell;
        }
    }
}