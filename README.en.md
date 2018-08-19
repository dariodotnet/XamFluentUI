# XamFluentUI
Fluent UI API for Xamarin Forms

With this set of extension methods, you can create views for your applications with Xamarin Forms using C#.

Currently there are only extension methods for the most common Xamarin Forms controls and the available methods and controls will be updated shortly.

To see the difference in creation with XAML, you can see what the MainView looks like from the example:

```C#
public class MainView : ContentPage
    {
        public MainView()
        {
            Content = new Grid()
                .AddContent(
                    new StackLayout()
                        .Alignment(LayoutOptions.Center, LayoutOptions.Center)
                        .AddContent(
                            new Label().TextAlignment(TextAlignment.Center, TextAlignment.Center)
                                .Text("Hello Xamarin Fluent", Color.Gray)));
        }
    }
```

Translated by [deepl.com/](https://www.deepl.com/)