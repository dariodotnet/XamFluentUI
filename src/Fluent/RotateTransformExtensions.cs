namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class RotateTransformExtensions
    {
        public static RotateTransform Angle(this RotateTransform transform, double angle)
        {
            transform.Angle = angle;
            return transform;
        }

        public static RotateTransform Center(this RotateTransform transform, (double, double) center)
        {
            transform.CenterX = center.Item1;
            transform.CenterY = center.Item2;
            return transform;
        }

        public static RotateTransform Define(this RotateTransform transform, double angle, (double, double) center)
        {
            return transform.Angle(angle).Center(center);
        }
    }
}