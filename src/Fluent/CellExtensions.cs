using Xamarin.Forms;

namespace Fluent
{
    public static class CellExtensions
    {
        public static Cell Height(this Cell cell, double height)
        {
            cell.Height = height;
            return cell;
        }

        public static Cell IsEnabled(this Cell cell, bool enabled)
        {
            cell.IsEnabled = enabled;
            return cell;
        }
    }
}