using Xamarin.Forms;

namespace Fluent
{
    public static class ImageCellExtensions
    {
        public static ImageCell ImageSource(this ImageCell cell, ImageSource source)
        {
            cell.ImageSource = source;
            return cell;
        }
    }
}