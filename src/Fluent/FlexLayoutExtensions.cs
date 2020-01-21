using Xamarin.Forms;

namespace Fluent
{
    public static class FlexLayoutExtensions
    {
        public static FlexLayout AlignContent(this FlexLayout layout, FlexAlignContent align)
        {
            layout.AlignContent = align;
            return layout;
        }

        public static FlexLayout AlignItems(this FlexLayout layout, FlexAlignItems align)
        {
            layout.AlignItems = align;
            return layout;
        }

        public static FlexLayout Align(this FlexLayout layout, FlexAlignContent content, FlexAlignItems items)
        {
            layout.AlignContent = content;
            layout.AlignItems = items;
            return layout;
        }

        public static FlexLayout Direction(this FlexLayout layout, FlexDirection direction)
        {
            layout.Direction = direction;
            return layout;
        }

        public static FlexLayout JustifyContent(this FlexLayout layout, FlexJustify justify)
        {
            layout.JustifyContent = justify;
            return layout;
        }

        public static FlexLayout Position(this FlexLayout layout, FlexPosition position)
        {
            layout.Position = position;
            return layout;
        }

        public static FlexLayout Wrap(this FlexLayout layout, FlexWrap wrap)
        {
            layout.Wrap = wrap;
            return layout;
        }

        public static FlexLayout Configure(this FlexLayout layout,
            FlexAlignContent alignContent = FlexAlignContent.Center,
            FlexAlignItems alignItems = FlexAlignItems.Center,
            FlexDirection direction = FlexDirection.Column,
            FlexJustify justify = FlexJustify.Center,
            FlexPosition position = FlexPosition.Absolute,
            FlexWrap wrap = FlexWrap.NoWrap)
        {
            layout.AlignContent = alignContent;
            layout.AlignItems = alignItems;
            layout.Direction = direction;
            layout.JustifyContent = justify;
            layout.Position = position;
            layout.Wrap = wrap;
            return layout;
        }
    }
}