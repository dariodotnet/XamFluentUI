namespace Fluent
{
    using System.Collections;
    using Xamarin.Forms;

    public static class IndicatorViewExtensions
    {
        public static IndicatorView Count(this IndicatorView indicator, int count)
        {
            indicator.Count = count;
            return indicator;
        }

        public static IndicatorView HideSingle(this IndicatorView indicator, bool hide)
        {
            indicator.HideSingle = hide;
            return indicator;
        }

        public static IndicatorView IndicatorColor(this IndicatorView indicator, Color color)
        {
            indicator.IndicatorColor = color;
            return indicator;
        }

        public static IndicatorView IndicatorLayout(this IndicatorView indicator, Layout<View> layout)
        {
            indicator.IndicatorLayout = layout;
            return indicator;
        }

        public static IndicatorView IndicatorSize(this IndicatorView indicator, double size)
        {
            indicator.IndicatorSize = size;
            return indicator;
        }

        public static IndicatorView IndicatorsShape(this IndicatorView indicator, IndicatorShape shape)
        {
            indicator.IndicatorsShape = shape;
            return indicator;
        }

        public static IndicatorView IndicatorTemplate(this IndicatorView indicator, DataTemplate template)
        {
            indicator.IndicatorTemplate = template;
            return indicator;
        }

        public static IndicatorView ItemsSource(this IndicatorView indicator, IEnumerable source)
        {
            indicator.ItemsSource = source;
            return indicator;
        }

        public static IndicatorView MaximumVisible(this IndicatorView indicator, int max)
        {
            indicator.MaximumVisible = max;
            return indicator;
        }

        public static IndicatorView Position(this IndicatorView indicator, int position)
        {
            indicator.Position = position;
            return indicator;
        }

        public static IndicatorView SelectedIndicatorColor(this IndicatorView indicator, Color color)
        {
            indicator.SelectedIndicatorColor = color;
            return indicator;
        }

        public static IndicatorView Color(this IndicatorView indicator, Color indicatorColor, Color selectedColor)
        {
            indicator.IndicatorColor = indicatorColor;
            indicator.SelectedIndicatorColor = selectedColor;
            return indicator;
        }
    }
}