# XamFluentUI
Fluent UI API para Xamarin Forms

Con este conjunto de métodos de extensión, puede crear vistas para sus aplicaciones con Xamarin Forms utilizando C#.

Para ver la diferencia en la creación con XAML, puede ver cómo se ve el MainView desde el ejemplo:

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

Puedes utilizar diferente modos para añadir vistas a tus "Layouts". De este modo el código se identará automaticamente en Visual Studio y favorecerá la legibilidad.

Puedes utilizar una función o añadir vistas directamente:

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