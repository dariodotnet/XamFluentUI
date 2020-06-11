namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class LineExtensions
    {
        public static Line Line(this Line line, (double, double) xCoordinates, (double, double) yCoordinates)
        {
            line.X1 = xCoordinates.Item1;
            line.X2 = xCoordinates.Item2;
            line.Y1 = yCoordinates.Item1;
            line.Y2 = yCoordinates.Item2;
            return line;
        }

        public static Line Line(this Line line, (double, double, double, double) coordinates)
        {
            return line.Line((coordinates.Item1, coordinates.Item2), (coordinates.Item3, coordinates.Item4));
        }
    }
}