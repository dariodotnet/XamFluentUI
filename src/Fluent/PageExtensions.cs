using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class PageExtensions
    {
        public static Page BackgroundImage(this Page page, string source)
        {
            page.BackgroundImage = source;
            return page;
        }
        
        public static Page Icon(this Page page, FileImageSource source)
        {
            page.Icon = source;
            return page;
        }
        
        public static Page IsBusy(this Page page, bool isBusy)
        {
            page.IsBusy = isBusy;
            return page;
        }
        
        public static Page Padding(this Page page, double uniformSize)
        {
            page.Padding = new Thickness(uniformSize);
            return page;
        }

        public static Page Padding(this Page page, double horizontal, double vertical)
        {
            page.Padding = new Thickness(horizontal, vertical);
            return page;
        }

        public static Page Padding(this Page page, double left, double top, double right, double bottom)
        {
            page.Padding = new Thickness(left, top, right, bottom);
            return page;
        }

        public static Page Title(this Page page, string title)
        {
            page.Title = title;
            return page;
        }
        
        public static Page ToolbarItems(this Page page, Func<IList<ToolbarItem>> items)
        {
            items.Invoke().ForEach(x => page.ToolbarItems.Add(x));
            return page;
        }
        
        public static Page ToolbarItems(this Page page, params ToolbarItem[] items)
        {
            items.ForEach(x => page.ToolbarItems.Add(x));
            return page;
        }
        
        public static Page ToolbarItems(this Page page, Func<ToolbarItem> item)
        {
            page.ToolbarItems.Add(item.Invoke());
            return page;
        }
    }
}