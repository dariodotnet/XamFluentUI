using Xamarin.Forms;

namespace Fluent
{
    public static class BaseShellItemExtensions
    {
        public static T FlyoutIcon<T>(this T shell, ImageSource flyoutIcon) where T : BaseShellItem
        {
            shell.FlyoutIcon = flyoutIcon;
            return shell;
        }

        public static T Icon<T>(this T shell, ImageSource icon) where T : BaseShellItem
        {
            shell.Icon = icon;
            return shell;
        }

        public static T IsEnabled<T>(this T shell, bool enabled) where T : BaseShellItem
        {
            shell.IsEnabled = enabled;
            return shell;
        }

        public static T Route<T>(this T shell, string route) where T : BaseShellItem
        {
            shell.Route = route;
            return shell;
        }

        public static T Title<T>(this T shell, string title) where T : BaseShellItem
        {
            shell.Title = title;
            return shell;
        }
    }
}