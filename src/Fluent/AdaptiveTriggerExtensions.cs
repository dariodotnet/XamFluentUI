namespace Fluent
{
    using Xamarin.Forms;

    public static class AdaptiveTriggerExtensions
    {
        public static AdaptiveTrigger MinWindowWidth(this AdaptiveTrigger trigger, double minWidth)
        {
            trigger.MinWindowWidth = minWidth;
            return trigger;
        }

        public static AdaptiveTrigger MinWindowHeight(this AdaptiveTrigger trigger, double minHeight)
        {
            trigger.MinWindowHeight = minHeight;
            return trigger;
        }

        public static AdaptiveTrigger Configure(this AdaptiveTrigger trigger, double minWidth, double minHeight)
        {
            trigger.MinWindowWidth = minWidth;
            trigger.MinWindowHeight = minHeight;
            return trigger;
        }
    }
}