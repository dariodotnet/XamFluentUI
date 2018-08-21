using System;
using Xamarin.Forms;

namespace Fluent
{
    public static class ContentPresenterExtensions
    {
        public static ContentPresenter Content(this ContentPresenter presenter, Func<View> content)
        {
            presenter.Content = content.Invoke();
            return presenter;
        }
        
        public static ContentPresenter Content(this ContentPresenter presenter, View content)
        {
            presenter.Content = content;
            return presenter;
        }
    }
}