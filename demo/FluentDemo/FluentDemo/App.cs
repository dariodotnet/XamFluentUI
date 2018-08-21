using Xamarin.Forms;

namespace FluentDemo
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainView());
        }
    }
}