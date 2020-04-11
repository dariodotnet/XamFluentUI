namespace Fluent
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public static class ExpanderExtensions
    {
        public static Expander CollapseAnimationEasing(this Expander expander, Easing easing, uint length = 0)
        {
            expander.CollapseAnimationEasing = easing;
            if (length > 0)
                expander.CollapseAnimationLength = length;
            return expander;
        }

        public static Expander CollapseAnimationLength(this Expander expander, uint length)
        {
            expander.CollapseAnimationLength = length;
            return expander;
        }

        public static Expander CommandParameter(this Expander expander, object parameter)
        {
            expander.CommandParameter = parameter;
            return expander;
        }

        public static Expander Command(this Expander expander, ICommand command, object parameter = null)
        {
            expander.Command = command;
            if (parameter != null)
                expander.CommandParameter = parameter;

            return expander;
        }

        public static Expander Content(this Expander expander, View content)
        {
            expander.Content = content;
            return expander;
        }

        public static Expander ContentTemplate(this Expander expander, DataTemplate template)
        {
            expander.ContentTemplate = template;
            return expander;
        }

        public static Expander ExpandAnimationEasing(this Expander expander, Easing easing, uint length = 0)
        {
            expander.ExpandAnimationEasing = easing;
            if (length > 0)
                expander.ExpandAnimationLength = length;
            return expander;
        }

        public static Expander ExpandAnimationLength(this Expander expander, uint length)
        {
            expander.ExpandAnimationLength = length;
            return expander;
        }

        public static Expander ForceUpdateSizeCommand(this Expander expander, ICommand command)
        {
            expander.ForceUpdateSizeCommand = command;
            return expander;
        }

        public static Expander Header(this Expander expander, View header)
        {
            expander.Header = header;
            return expander;
        }

        public static Expander IsExpanded(this Expander expander, bool isExpanded)
        {
            expander.IsExpanded = isExpanded;
            return expander;
        }

        public static Expander Spacing(this Expander expander, double spacing)
        {
            expander.Spacing = spacing;
            return expander;
        }

        public static Expander State(this Expander expander, ExpanderState state)
        {
            expander.State = state;
            return expander;
        }
    }
}