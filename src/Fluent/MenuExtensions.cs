using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class MenuExtensions
    {
        public static Menu Text(this Menu menu, string text)
        {
            menu.Text = text;
            return menu;
        }

        public static Menu Items(this Menu menu, ObservableCollection<MenuItem> items)
        {
            items.ForEach(i => menu.Items.Add(i));
            return menu;
        }
    }
}