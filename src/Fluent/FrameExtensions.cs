using Xamarin.Forms;

namespace Fluent
{
    public static class FrameExtensions
    {
        public static Frame BorderColor(this Frame frame, Color color)
        {
            frame.BorderColor = color;
            return frame;
        }

        public static Frame CornerRadius(this Frame frame, float radius)
        {
            frame.CornerRadius = radius;
            return frame;
        }

        public static Frame HasShadow(this Frame frame, bool hasShadow)
        {
            frame.HasShadow = hasShadow;
            return frame;
        }
    }
}