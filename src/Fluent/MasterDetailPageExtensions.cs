using Xamarin.Forms;

namespace Fluent
{
    public static class MasterDetailPageExtensions
    {
        public static MasterDetailPage Detail(this MasterDetailPage page, Page detail)
        {
            page.Detail = detail;
            return page;
        }

        public static MasterDetailPage IsGestureEnabled(this MasterDetailPage page, bool enabled)
        {
            page.IsGestureEnabled = enabled;
            return page;
        }

        public static MasterDetailPage IsPresented(this MasterDetailPage page, bool presented)
        {
            page.IsPresented = presented;
            return page;
        }

        public static MasterDetailPage Master(this MasterDetailPage page, Page master)
        {
            page.Master = master;
            return page;
        }

        public static MasterDetailPage MasterBehavior(this MasterDetailPage page, MasterBehavior behavior)
        {
            page.MasterBehavior = behavior;
            return page;
        }
    }
}