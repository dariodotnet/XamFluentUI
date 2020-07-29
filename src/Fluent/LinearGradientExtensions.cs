namespace Fluent
{
    using Xamarin.Forms;

    public static class LinearGradientExtensions
    {
        public static LinearGradientBrush EndPoint(this LinearGradientBrush gradient, Point point)
        {
            gradient.EndPoint = point;
            return gradient;
        }

        public static LinearGradientBrush StartPoint(this LinearGradientBrush gradient, Point point)
        {
            gradient.StartPoint = point;
            return gradient;
        }

        public static LinearGradientBrush Points(this LinearGradientBrush gradient, Point start, Point end)
        {
            gradient.StartPoint = start;
            gradient.EndPoint = end;
            return gradient;
        }

        public static LinearGradientBrush Points(this LinearGradientBrush gradient, (Point, Point) points) =>
            gradient.StartPoint(points.Item1).EndPoint(points.Item2);
    }
}