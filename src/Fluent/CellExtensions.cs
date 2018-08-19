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

    public static class EntryCellExtensions
    {
        public static EntryCell HorizontalTextAlignment(this EntryCell cell, TextAlignment alignment)
        {
            cell.HorizontalTextAlignment = alignment;
            return cell;
        }
        
        public static EntryCell Keyboard(this EntryCell cell, Keyboard keyboard)
        {
            cell.Keyboard = keyboard;
            return cell;
        }
        
        public static EntryCell Text(this EntryCell cell, string text, string label = "", string placeholder = "", Color color = default(Color))
        {
            cell.Label = label;
            cell.Placeholder = placeholder;
            cell.LabelColor = color;
            cell.Text = text;
            return cell;
        }
    }
}