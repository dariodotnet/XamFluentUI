namespace Fluent
{
    using Xamarin.Forms;

    public static class HtmlWebViewSourceExtensions
    {
        public static HtmlWebViewSource BaseUrl(this HtmlWebViewSource web, string url)
        {
            web.BaseUrl = url;
            return web;
        }

        public static HtmlWebViewSource Html(this HtmlWebViewSource web, string html)
        {
            web.Html = html;
            return web;
        }
    }
}