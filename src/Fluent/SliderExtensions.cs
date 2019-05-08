using Xamarin.Forms;

namespace Fluent
{
    using System;

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

        [Obsolete("Slider.ThumbImage is obsolete: Image is obsolete as of 4.0.0. Please use ThumbImageSource instead.")]
        public static Slider ThumbImage(this Slider slider, FileImageSource source)
        {
            slider.ThumbImage = source;
            return slider;
        }

        public static Slider ThumbImageSource(this Slider slider, ImageSource source)
        {
            slider.ThumbImageSource = source;
            return slider;
        }
    }
}