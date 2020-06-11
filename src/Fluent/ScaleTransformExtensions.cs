namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class ScaleTransformExtensions
    {
        public static ScaleTransform Center(this ScaleTransform transform, (double, double) center)
        {
            transform.CenterX = center.Item1;
            transform.CenterY = center.Item2;
            return transform;
        }

        public static ScaleTransform Scale(this ScaleTransform transform, (double, double) scale)
        {
            transform.ScaleX = scale.Item1;
            transform.ScaleY = scale.Item2;
            return transform;
        }

        public static ScaleTransform Define(this ScaleTransform transform, (double, double) center, (double, double) scale)
        {
            return transform.Center(center).Scale(scale);
        }
    }
}