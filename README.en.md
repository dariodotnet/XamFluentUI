# XamFluentUI
Fluent UI API for Xamarin Forms

With this set of extension methods, you can create views for your Xamarin Forms applications using C#.

To see the difference in creation with XAML, you can see what the MainView looks like from the example:e:

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

You can use different ways to add views to your layouts. This way, the code will be automatically created in Visual Studio and will make it easier to read.

You can use a function or add views directly:

```C#
var demo = new Grid().AddContent(() => new List<View>
{
    //Aquí las vistas
});

var demo = new Grid().AddContent(new View[]
{
    //Aquí las vistas
});

var demo = new Grid().AddContent(
    //Aquí las vistas
    );
```

Translated by [deepl.com/](https://www.deepl.com/)