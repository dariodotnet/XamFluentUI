using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class ViewExtensions
    {
        public static T Alignment<T>(this T view, LayoutOptions horizontal = default(LayoutOptions),
            LayoutOptions vertical = default(LayoutOptions)) where T : View
        {
            view.HorizontalOptions = horizontal;
            view.VerticalOptions = vertical;
            return view;
        }

        public static T Margin<T>(this T view, double uniformSize) where T : View
        {
            view.Margin = new Thickness(uniformSize);
            return view;
        }

        public static T Margin<T>(this T view, double horizontal, double vertical) where T : View
        {
            view.Margin = new Thickness(horizontal, vertical);
            return view;
        }

        public static T Margin<T>(this T view, double left, double top, double right, double bottom) where T : View
        {
            view.Margin = new Thickness(left, top, right, bottom);
            return view;
        }

        public static T GridParent<T>(this T view, int row = 0, int column = 0, int rowSpan = 1, int columnSpan = 1) where T : View
        {
            Grid.SetRow(view, row);
            Grid.SetColumn(view, column);
            Grid.SetRowSpan(view, rowSpan);
            Grid.SetColumnSpan(view, columnSpan);
            return view;
        }

        public static T GestureRecognizers<T>(this T view, Func<IList<IGestureRecognizer>> gestures) where T : View
        {
            gestures.Invoke().ForEach(x => view.GestureRecognizers.Add(x));
            return view;
        }
    }
}