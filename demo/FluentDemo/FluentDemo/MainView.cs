using Fluent;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FluentDemo
{
    public class MainView : ContentPage
    {
        private readonly Grid MainGrid = new Grid();
        private readonly StackLayout MainStack = new StackLayout();
        private readonly Label Label = new Label();

        public MainView()
        {
            InitView();
        }

        private void InitView()
        {
            Content = MainGrid.RowsAndColumns(2)
                .AddContent(() => new List<View>
            {
                MainStack.GridParent(0,0,2)
                    .Alignment(LayoutOptions.Center, LayoutOptions.Center)
                    .AddContent(() => new List<View>
                    {
                        Label.TextAlignment(TextAlignment.Center, TextAlignment.Center)
                            .Text("Hello Xamarin Fluent!!!")
                            .TextColor(Color.Gray)
                    })
            });
        }
    }
}