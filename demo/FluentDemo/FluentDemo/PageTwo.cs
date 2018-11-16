using Fluent;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FluentDemo
{
    public class PageTwo : ContentPage
    {
        private Button ClickMe = new Button();
        private TapGestureRecognizer TapBack = new TapGestureRecognizer();

        public PageTwo()
        {
            Content = new Grid()
                .BackgroundColor(Color.LightSeaGreen)
                .AddContent(() => new List<View>
                {
                    new StackLayout().Alignment(LayoutOptions.Center, LayoutOptions.Center)
                        .AddContent(
                            new Entry().Placeholder("Placeholder text", Color.DarkSlateGray),
                            ClickMe.BackgroundColor(Color.LightSkyBlue)
                                .Text("ClickMe", Color.Black)
                                .CornerRadius(5)
                                .FontAttributes(FontAttributes.Bold),
                            new Grid().BackgroundColor(Color.LightCoral)
                                .Alignment(LayoutOptions.StartAndExpand)
                                .SizeRequest(ClickMe.Width, ClickMe.Height)
                                .AddContent(() => new List<View>
                                {
                                    new Label().Text("Go back")
                                })
                                .GestureRecognizers(() => new[] { TapBack.TappedEvent(GoBack) }))
                });
        }

        private async void GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync(true);
        }
    }
}