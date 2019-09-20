using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class SearchBarExtensions
    {
        public static SearchBar CancelButtonColor(this SearchBar searchBar, Color color)
        {
            searchBar.CancelButtonColor = color;
            return searchBar;
        }

        public static SearchBar Placeholder(this SearchBar searchBar, string placeholder)
        {
            searchBar.Placeholder = placeholder;
            return searchBar;
        }

        public static SearchBar Placeholder(this SearchBar searchBar, string placeholder, Color textColor = default(Color))
        {
            searchBar.Placeholder = placeholder;
            searchBar.PlaceholderColor = textColor;
            return searchBar;
        }

        public static SearchBar SearchCommand(this SearchBar searchBar, ICommand command)
        {
            searchBar.SearchCommand = command;
            return searchBar;
        }

        public static SearchBar SearchCommand(this SearchBar searchBar, ICommand command, object parameter)
        {
            searchBar.SearchCommand = command;
            searchBar.SearchCommandParameter = parameter;
            return searchBar;
        }

        public static SearchBar SearchCommandParameter(this SearchBar searchBar, object parameter)
        {
            searchBar.SearchCommandParameter = parameter;
            return searchBar;
        }

        #region TextProperties

        public static SearchBar FontAttributes(this SearchBar searchBar, FontAttributes attributes)
        {
            searchBar.FontAttributes = attributes;
            return searchBar;
        }

        public static SearchBar FontFamily(this SearchBar searchBar, string fontFamily)
        {
            searchBar.FontFamily = fontFamily;
            return searchBar;
        }

        public static SearchBar FontSize(this SearchBar searchBar, double fontSize)
        {
            searchBar.FontSize = fontSize;
            return searchBar;
        }

        public static SearchBar HorizontalTextAlignment(this SearchBar searchBar, TextAlignment alignment)
        {
            searchBar.HorizontalTextAlignment = alignment;
            return searchBar;
        }

        public static SearchBar VerticalTextAlignment(this SearchBar searchBar, TextAlignment alignment)
        {
            searchBar.VerticalTextAlignment = alignment;
            return searchBar;
        }

        public static SearchBar TextAlignment(this SearchBar searchBar, TextAlignment horizontalAlignment, TextAlignment verticalAlignment)
        {
            searchBar.HorizontalTextAlignment = horizontalAlignment;
            searchBar.VerticalTextAlignment = verticalAlignment;
            return searchBar;
        }

        public static SearchBar Text(this SearchBar searchBar, string text)
        {
            searchBar.Text = text;
            return searchBar;
        }

        public static SearchBar Text(this SearchBar searchBar, string text, Color textColor = default(Color))
        {
            searchBar.Text = text;
            searchBar.TextColor = textColor;
            return searchBar;
        }

        public static SearchBar CharacterSpacing(this SearchBar searchBar, double spacing)
        {
            searchBar.CharacterSpacing = spacing;
            return searchBar;
        }

        #endregion
    }
}