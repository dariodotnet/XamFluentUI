using Xamarin.Forms;

namespace Fluent
{
    public static class ItemsLayoutExtensions
    {
        public static T SnapPointsAlignment<T>(this T element, SnapPointsAlignment alignment) where T : ItemsLayout
        {
            element.SnapPointsAlignment = alignment;
            return element;
        }

        public static T SnapPointsType<T>(this T element, SnapPointsType type) where T : ItemsLayout
        {
            element.SnapPointsType = type;
            return element;
        }

        public static T SnapPoints<T>(this T element, SnapPointsAlignment alignment, SnapPointsType type) where T : ItemsLayout
        {
            element.SnapPointsAlignment = alignment;
            element.SnapPointsType = type;
            return element;
        }
    }
}