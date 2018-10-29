using Xamarin.Forms;

namespace Fluent
{
    public static class WebViewExtensions
    {
        public static WebView Source(this WebView webView, WebViewSource source)
        {
            webView.Source = source;
            return webView;
        }
    }
}