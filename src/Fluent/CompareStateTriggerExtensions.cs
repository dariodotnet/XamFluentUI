namespace Fluent
{
    using Xamarin.Forms;

    public static class CompareStateTriggerExtensions
    {
        public static CompareStateTrigger Property(this CompareStateTrigger trigger, object property)
        {
            trigger.Property = property;
            return trigger;
        }

        public static CompareStateTrigger Value(this CompareStateTrigger trigger, object value)
        {
            trigger.Value = value;
            return trigger;
        }

        public static CompareStateTrigger Configure(this CompareStateTrigger trigger, object property, object value)
        {
            trigger.Property = property;
            trigger.Value = value;
            return trigger;
        }
    }
}