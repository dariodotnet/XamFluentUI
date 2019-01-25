using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class ShellSectionExtensions
    {
        public static ShellSection Items(this ShellSection shell, ShellContentCollection collection)
        {
            collection.ForEach(section => shell.Items.Add(section));
            return shell;
        }

        public static ShellSection Items(this ShellSection shell, Func<ShellContentCollection> collection)
        {
            collection.Invoke().ForEach(section => shell.Items.Add(section));
            return shell;
        }
    }
}