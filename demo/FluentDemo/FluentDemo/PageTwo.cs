using System.Collections.Generic;
using Fluent;
using Xamarin.Forms;

namespace FluentDemo
{
    public class PageTwo : ContentPage
    {
        public PageTwo()
        {
            Content = new Grid()
                .BackgroundColor(Color.LightSeaGreen)
                .AddContent(() => new List<View>
                {
                    new StackLayout().Alignment(LayoutOptions.Center, LayoutOptions.Center)
                        .AddContent(
                            new Entry().Placeholder("Placeholder text", Color.DarkSlateGray), 
                            new Button().BackgroundColor(Color.LightSkyBlue)
                                .Text("ClickMe", Color.Black)
                                .CornerRadius(5)
                                .FontAttributes(FontAttributes.Bold))
                });
        }
    }
}