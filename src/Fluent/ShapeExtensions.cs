namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Shapes;

    public static class ShapeExtensions
    {
        public static T Aspect<T>(this T shape, Stretch aspect) where T : Shape
        {
            shape.Aspect = aspect;
            return shape;
        }

        public static T Fill<T>(this T shape, Brush fill) where T : Shape
        {
            shape.Fill = fill;
            return shape;
        }

        public static T Stroke<T>(this T shape, Brush stroke) where T : Shape
        {
            shape.Stroke = stroke;
            return shape;
        }

        public static T StrokeDashArray<T>(this T shape, DoubleCollection collection) where T : Shape
        {
            shape.StrokeDashArray = collection;
            return shape;
        }

        public static T StrokeDashOffset<T>(this T shape, double offSet) where T : Shape
        {
            shape.StrokeDashOffset = offSet;
            return shape;
        }

        public static T StrokeLineCap<T>(this T shape, PenLineCap penLineCap) where T : Shape
        {
            shape.StrokeLineCap = penLineCap;
            return shape;
        }

        public static T StrokeLineJoin<T>(this T shape, PenLineJoin penLineJoin) where T : Shape
        {
            shape.StrokeLineJoin = penLineJoin;
            return shape;
        }

        public static T StrokeThickness<T>(this T shape, double strokeThickness) where T : Shape
        {
            shape.StrokeThickness = strokeThickness;
            return shape;
        }

        public static T Shape<T>(this T shape, Stretch aspect, Brush fill, Brush stroke,
            DoubleCollection doubleCollection, double offSet,
            PenLineCap penLineCap, PenLineJoin penLineJoin, double strokeThickness) where T : Shape
        {
            return shape.Aspect(aspect).Fill(fill)
                .Stroke(stroke).StrokeDashArray(doubleCollection)
                .StrokeDashOffset(offSet).StrokeLineCap(penLineCap)
                .StrokeLineJoin(penLineJoin).StrokeThickness(strokeThickness);
        }
    }
}