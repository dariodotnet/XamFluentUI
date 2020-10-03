namespace Fluent
{
    using Xamarin.Forms;

    public static class FlyoutPageExtensions
    {
        public static FlyoutPage FlyoutLayoutBehavior(this FlyoutPage page, FlyoutLayoutBehavior behavior)
        {
            page.FlyoutLayoutBehavior = behavior;
            return page;
        }

        public static FlyoutPage IsGestureEnabled(this FlyoutPage page, bool enabled)
        {
            page.IsGestureEnabled = enabled;
            return page;
        }

        public static FlyoutPage IsPresented(this FlyoutPage page, bool presented)
        {
            page.IsPresented = presented;
            return page;
        }
    }
}