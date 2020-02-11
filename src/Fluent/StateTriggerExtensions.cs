namespace Fluent
{
    using Xamarin.Forms;

    public static class StateTriggerExtensions
    {
        public static StateTrigger IsActive(this StateTrigger trigger, bool isActive)
        {
            trigger.IsActive = isActive;
            return trigger;
        }
    }
}