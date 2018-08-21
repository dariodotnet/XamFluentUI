using Fluent;
using System;
using Xamarin.Forms;

namespace FluentDemo
{
    public class MainView : ContentPage
    {
        private readonly Button NavigateTo = new Button();
        public MainView()
        {
            Content = new Grid()
                .AddContent(
                    new StackLayout()
                        .Alignment(LayoutOptions.Center, LayoutOptions.Center)
                        .AddContent(
                            new Label().TextAlignment(TextAlignment.Center, TextAlignment.Center)
                                .Text("Hello Xamarin Fluent", Color.Gray),
                            NavigateTo.BackgroundColor(Color.CornflowerBlue)
                                .Text("Go to page two", Color.DarkSlateGray))
                   );

            NavigateTo.Clicked += NavigateToOnClicked;
        }

        private void NavigateToOnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PageTwo());
        }
    }
}