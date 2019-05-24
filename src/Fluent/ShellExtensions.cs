using Xamarin.Forms;

namespace Fluent
{
    public static class ShellExtensions
    {
        public static Shell BackgroundColor(this Shell shell, Color color)
        {
            shell.BackgroundColor = color;
            return shell;
        }

        public static Shell CurrentItem(this Shell shell, ShellItem item)
        {
            shell.CurrentItem = item;
            return shell;
        }

        public static Shell FlyoutBackgroundColor(this Shell shell, Color color)
        {
            shell.FlyoutBackgroundColor = color;
            return shell;
        }

        public static Shell FlyoutBehavior(this Shell shell, FlyoutBehavior behavior)
        {
            shell.FlyoutBehavior = behavior;
            return shell;
        }

        public static Shell FlyoutHeader(this Shell shell, object header)
        {
            shell.FlyoutHeader = header;
            return shell;
        }

        public static Shell FlyoutHeader(this Shell shell, object header, DataTemplate template,
            FlyoutHeaderBehavior behavior = Xamarin.Forms.FlyoutHeaderBehavior.Default)
        {
            shell.FlyoutHeader = header;
            shell.FlyoutHeaderTemplate = template;
            shell.FlyoutHeaderBehavior = behavior;
            return shell;
        }

        public static Shell FlyoutHeaderBehavior(this Shell shell, FlyoutHeaderBehavior behavior)
        {
            shell.FlyoutHeaderBehavior = behavior;
            return shell;
        }

        public static Shell FlyoutHeaderTemplate(this Shell shell, DataTemplate template)
        {
            shell.FlyoutHeaderTemplate = template;
            return shell;
        }

        public static Shell FlyoutIsPresented(this Shell shell, bool presented)
        {
            shell.FlyoutIsPresented = presented;
            return shell;
        }

        public static Shell FlyoutIcon(this Shell shell, ImageSource source)
        {
            shell.FlyoutIcon = source;
            return shell;
        }

        public static Shell ItemTemplate(this Shell shell, DataTemplate template)
        {
            shell.ItemTemplate = template;
            return shell;
        }

        public static Shell MenuItemTemplate(this Shell shell, DataTemplate template)
        {
            shell.MenuItemTemplate = template;
            return shell;
        }
    }
}