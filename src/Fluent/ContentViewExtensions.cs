using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class ContentViewExtensions
    {
        public static ContentView Content(this ContentView view, Func<View> content)
        {
            view.Content = content.Invoke();
            return view;
        }
        
        public static ContentView Content(this ContentView view, View content)
        {
            view.Content = content;
            return view;
        }
    }
}