using Xamarin.Forms;

namespace Fluent
{
    public static class SliderExtensions
    {
        public static Slider MaxAndMin(this Slider slider, double max, double min = 0)
        {
            slider.Minimum = min;
            slider.Maximum = max;
            return slider;
        }

        public static Slider TrackColors(this Slider slider, Color minColor = default(Color), Color maxColor = default(Color))
        {
            slider.MinimumTrackColor = minColor;
            slider.MaximumTrackColor = maxColor;
            return slider;
        }

        public static Slider ThumbColor(this Slider slider, Color color)
        {
            slider.ThumbColor = color;
            return slider;
        }

        public static Slider ThumbImage(this Slider slider, FileImageSource source)
        {
            slider.ThumbImage = source;
            return slider;
        }
    }
}