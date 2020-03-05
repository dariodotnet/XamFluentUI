using Xamarin.Forms;

namespace Fluent
{
    using System.Net;

    public static class WebViewExtensions
    {
        public static WebView Source(this WebView webView, WebViewSource source)
        {
            webView.Source = source;
            return webView;
        }

        public static WebView Cookies(this WebView webView, CookieContainer container)
        {
            webView.Cookies = container;
            return webView;
        }

        public static WebView Config(this WebView webView, WebViewSource source, CookieContainer container)
        {
            webView.Source = source;
            webView.Cookies = container;

            return webView;
        }
    }
}