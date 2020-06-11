namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class TranslateTransformExtensions
    {
        public static TranslateTransform Define(this TranslateTransform transform, (double, double) points)
        {
            transform.X = points.Item1;
            transform.Y = points.Item2;
            return transform;
        }
    }
}