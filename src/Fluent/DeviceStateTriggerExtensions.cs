namespace Fluent
{
    using Xamarin.Forms;

    public static class DeviceStateTriggerExtensions
    {
        public static DeviceStateTrigger Device(this DeviceStateTrigger trigger, string device)
        {
            trigger.Device = device;
            return trigger;
        }
    }
}