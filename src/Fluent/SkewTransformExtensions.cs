namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class SkewTransformExtensions
    {
        public static SkewTransform Angle(this SkewTransform transform, (double, double) angle)
        {
            transform.AngleX = angle.Item1;
            transform.AngleY = angle.Item2;
            return transform;
        }

        public static SkewTransform Center(this SkewTransform transform, (double, double) center)
        {
            transform.CenterX = center.Item1;
            transform.CenterY = center.Item2;
            return transform;
        }

        public static SkewTransform Define(this SkewTransform transform, (double, double) angle, (double, double) center)
        {
            return transform.Angle(angle).Center(center);
        }
    }
}