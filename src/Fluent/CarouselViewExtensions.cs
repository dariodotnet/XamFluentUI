using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class CarouselViewExtensions
    {
        public static CarouselView CurrentItem(this CarouselView carousel, object item)
        {
            carousel.CurrentItem = item;
            return carousel;
        }

        public static CarouselView CurrentItemChangedCommand(this CarouselView carousel, ICommand command, object parameter = null)
        {
            carousel.CurrentItemChangedCommand = command;
            carousel.CurrentItemChangedCommandParameter = parameter;
            return carousel;
        }

        public static CarouselView IsBounceEnabled(this CarouselView carousel, bool enabled)
        {
            carousel.IsBounceEnabled = enabled;
            return carousel;
        }

        public static CarouselView IsScrollAnimated(this CarouselView carousel, bool animated)
        {
            carousel.IsScrollAnimated = animated;
            return carousel;
        }

        public static CarouselView IsSwipeEnabled(this CarouselView carousel, bool enabled)
        {
            carousel.IsSwipeEnabled = enabled;
            return carousel;
        }

        public static CarouselView PeekAreaInsets(this CarouselView carousel, Thickness area)
        {
            carousel.PeekAreaInsets = area;
            return carousel;
        }

        public static CarouselView PositionChangedCommand(this CarouselView carousel, ICommand command, object parameter = null)
        {
            carousel.PositionChangedCommand = command;
            carousel.PositionChangedCommandParameter = parameter;
            return carousel;
        }

        public static CarouselView Position(this CarouselView carousel, int position)
        {
            carousel.Position = position;
            return carousel;
        }

        public static CarouselView ItemsLayout(this CarouselView carousel, LinearItemsLayout layout)
        {
            carousel.ItemsLayout = layout;
            return carousel;
        }
    }
}