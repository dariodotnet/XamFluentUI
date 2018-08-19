using Xamarin.Forms;

namespace Fluent
{
    public static class StepperExtensions
    {
        public static Stepper Configure(this Stepper stepper, double min, double max, double increment)
        {
            stepper.Increment = increment;
            stepper.Minimum = min;
            stepper.Maximum = max;
            return stepper;
        }
    }
}