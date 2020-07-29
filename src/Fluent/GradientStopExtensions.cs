namespace Fluent
{
    using Xamarin.Forms;

    public static class GradientStopExtensions
    {
        public static GradientStop Color(this GradientStop stop, Color color)
        {
            stop.Color = color;
            return stop;
        }

        public static GradientStop Offset(this GradientStop stop, float offset)
        {
            stop.Offset = offset;
            return stop;
        }

        public static GradientStop Configure(this GradientStop stop, Color color, float offset)
        {
            return stop.Color(color).Offset(offset);
        }

        public static GradientStop Configure(this GradientStop stop, (Color, float) configuration) =>
            stop.Color(configuration.Item1).Offset(configuration.Item2);
    }
}