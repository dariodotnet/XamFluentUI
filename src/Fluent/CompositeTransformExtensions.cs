namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class CompositeTransformExtensions
    {
        public static CompositeTransform Center(this CompositeTransform transform, (double, double) center)
        {
            transform.CenterX = center.Item1;
            transform.CenterY = center.Item2;
            return transform;
        }

        public static CompositeTransform Rotation(this CompositeTransform transform, double rotation)
        {
            transform.Rotation = rotation;
            return transform;
        }

        public static CompositeTransform Scale(this CompositeTransform transform, (double, double) scale)
        {
            transform.ScaleX = scale.Item1;
            transform.ScaleY = scale.Item2;
            return transform;
        }

        public static CompositeTransform Skew(this CompositeTransform transform, (double, double) skew)
        {
            transform.SkewX = skew.Item1;
            transform.SkewY = skew.Item2;
            return transform;
        }

        public static CompositeTransform Translate(this CompositeTransform transform, (double, double) translate)
        {
            transform.TranslateX = translate.Item1;
            transform.TranslateY = translate.Item2;
            return transform;
        }

        public static CompositeTransform Transform(this CompositeTransform transform,
            (double, double) center,
            double rotation,
            (double, double) scale,
            (double, double) skew,
            (double, double) translate)
        {
            return transform.Center(center)
                .Rotation(rotation)
                .Scale(scale).Skew(skew).Translate(translate);
        }
    }
}