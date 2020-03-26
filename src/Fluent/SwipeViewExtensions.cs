namespace Fluent
{
    using System;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using Xamarin.Forms.Internals;

    public static class SwipeViewExtensions
    {
        public static SwipeView BottomItems(this SwipeView view, IList<SwipeItem> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.BottomItems.Add(item));
            return view;
        }

        public static SwipeView BottomItems(this SwipeView view, Func<IList<SwipeItem>> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.Invoke().ForEach(item => view.BottomItems.Add(item));
            return view;
        }

        public static SwipeView BottomItems(this SwipeView view, params SwipeItem[] items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.BottomItems.Add(item));
            return view;
        }

        public static SwipeView BottomItems(this SwipeView view, SwipeItem item)
        {
            if (item is null)
                throw new ArgumentNullException();

            view.BottomItems.Add(item);
            return view;
        }

        public static SwipeView LeftItems(this SwipeView view, IList<SwipeItem> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.LeftItems.Add(item));
            return view;
        }

        public static SwipeView LeftItems(this SwipeView view, Func<IList<SwipeItem>> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.Invoke().ForEach(item => view.LeftItems.Add(item));
            return view;
        }

        public static SwipeView LeftItems(this SwipeView view, params SwipeItem[] items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.LeftItems.Add(item));
            return view;
        }

        public static SwipeView LeftItems(this SwipeView view, SwipeItem item)
        {
            if (item is null)
                throw new ArgumentNullException();

            view.LeftItems.Add(item);
            return view;
        }

        public static SwipeView RightItems(this SwipeView view, IList<SwipeItem> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.RightItems.Add(item));
            return view;
        }

        public static SwipeView RightItems(this SwipeView view, Func<IList<SwipeItem>> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.Invoke().ForEach(item => view.RightItems.Add(item));
            return view;
        }

        public static SwipeView RightItems(this SwipeView view, params SwipeItem[] items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.RightItems.Add(item));
            return view;
        }

        public static SwipeView RightItems(this SwipeView view, SwipeItem item)
        {
            if (item is null)
                throw new ArgumentNullException();

            view.RightItems.Add(item);
            return view;
        }

        public static SwipeView TopItems(this SwipeView view, IList<SwipeItem> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.TopItems.Add(item));
            return view;
        }

        public static SwipeView TopItems(this SwipeView view, Func<IList<SwipeItem>> items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.Invoke().ForEach(item => view.TopItems.Add(item));
            return view;
        }

        public static SwipeView TopItems(this SwipeView view, params SwipeItem[] items)
        {
            if (items is null)
                throw new ArgumentNullException();

            items.ForEach(item => view.TopItems.Add(item));
            return view;
        }

        public static SwipeView TopItems(this SwipeView view, SwipeItem item)
        {
            if (item is null)
                throw new ArgumentNullException();

            view.TopItems.Add(item);
            return view;
        }

        public static SwipeView SetItems(this SwipeView view, IList<SwipeItem> bottom = null, IList<SwipeItem> left = null, IList<SwipeItem> right = null, IList<SwipeItem> top = null)
        {
            bottom?.ForEach(item => view.BottomItems.Add(item));
            left?.ForEach(item => view.LeftItems.Add(item));
            right?.ForEach(item => view.RightItems.Add(item));
            top?.ForEach(item => view.TopItems.Add(item));

            return view;
        }

        public static SwipeView SetItems(this SwipeView view, Func<IList<SwipeItem>> bottom = null, Func<IList<SwipeItem>> left = null, Func<IList<SwipeItem>> right = null, Func<IList<SwipeItem>> top = null)
        {
            bottom?.Invoke().ForEach(item => view.BottomItems.Add(item));
            left?.Invoke().ForEach(item => view.LeftItems.Add(item));
            right?.Invoke().ForEach(item => view.RightItems.Add(item));
            top?.Invoke().ForEach(item => view.TopItems.Add(item));

            return view;
        }
    }
}