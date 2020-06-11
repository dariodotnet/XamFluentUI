namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class RectangleGeometryExtensions
    {
        public static RectangleGeometry Rect(this RectangleGeometry rect, Xamarin.Forms.Rectangle rectangle)
        {
            rect.Rect = rectangle;
            return rect;
        }
    }
}