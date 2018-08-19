using Xamarin.Forms;

namespace Fluent
{
    public static class ActivityIndicatorExtensions
    {
        public static ActivityIndicator Color(this ActivityIndicator indicator, Color color)
        {
            indicator.Color = color;
            return indicator;
        }

        public static ActivityIndicator IsRunning(this ActivityIndicator indicator, bool isRunning)
        {
            indicator.IsRunning = isRunning;
            return indicator;
        }
    }
}