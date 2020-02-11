using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class ViewCellExtensions
    {
        public static ViewCell View(this ViewCell viewCell, Func<View> view)
        {
            viewCell.View = view.Invoke();
            return viewCell;
        }

        public static ViewCell View(this ViewCell viewCell, View view)
        {
            viewCell.View = view;
            return viewCell;
        }
    }
}