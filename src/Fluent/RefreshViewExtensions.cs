namespace Fluent
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public static class RefreshViewExtensions
    {
        public static RefreshView Command(this RefreshView view, ICommand command, object parameter = null)
        {
            view.Command = command;
            view.CommandParameter = parameter;
            return view;
        }

        public static RefreshView IsRefreshing(this RefreshView view, bool refreshing)
        {
            view.IsRefreshing = refreshing;
            return view;
        }

        public static RefreshView RefreshColor(this RefreshView view, Color color)
        {
            view.RefreshColor = color;
            return view;
        }
    }
}