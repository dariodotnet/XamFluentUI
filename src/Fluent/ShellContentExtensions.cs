using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class ShellContentExtensions
    {
        public static ShellContent Content(this ShellContent shell, object content)
        {
            shell.Content = content;
            return shell;
        }

        public static ShellContent ContentTemplate(this ShellContent shell, DataTemplate template)
        {
            shell.ContentTemplate = template;
            return shell;
        }

        public static ShellContent MenuItems(this ShellContent shell, MenuItemCollection collection)
        {
            collection.ForEach(item => shell.MenuItems.Add(item));
            return shell;
        }

        public static ShellContent MenuItems(this ShellContent shell, Func<MenuItemCollection> collection)
        {
            collection.Invoke().ForEach(item => shell.MenuItems.Add(item));
            return shell;
        }
    }
}