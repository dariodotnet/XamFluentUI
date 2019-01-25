using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class ShellItemExtensions
    {
        public static T CurrentItem<T>(this T shell, ShellSection section) where T : ShellItem
        {
            shell.CurrentItem = section;
            return shell;
        }

        public static T AddSections<T>(this T shell, ShellSectionCollection sections) where T : ShellItem
        {
            sections.ForEach(section => shell.Items.Add(section));
            return shell;
        }

        public static T AddSections<T>(this T shell, Func<ShellSectionCollection> sections) where T : ShellItem
        {
            sections.Invoke().ForEach(section => shell.Items.Add(section));
            return shell;
        }
    }
}