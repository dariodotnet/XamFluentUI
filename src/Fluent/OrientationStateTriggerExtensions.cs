namespace Fluent
{
    using Xamarin.Forms;
    using Xamarin.Forms.Internals;

    public static class OrientationStateTriggerExtensions
    {
        public static OrientationStateTrigger Orientation(this OrientationStateTrigger trigger,
            DeviceOrientation orientation)
        {
            trigger.Orientation = orientation;
            return trigger;
        }
    }
}