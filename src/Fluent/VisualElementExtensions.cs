using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class VisualElementExtensions
    {
        public static T Anchor<T>(this T visual, double anchorX, double anchorY) where T : VisualElement
        {
            visual.AnchorX = anchorX;
            visual.AnchorY = anchorY;
            return visual;
        }

        public static T BackgroundColor<T>(this T visual, Color color) where T : VisualElement
        {
            visual.BackgroundColor = color;
            return visual;
        }

        public static T Behaviors<T>(this T visual, Func<IList<Behavior>> behaviors) where T : VisualElement
        {
            behaviors.Invoke().ForEach(x => visual.Behaviors.Add(x));
            return visual;
        }

        public static T Behaviors<T>(this T visual, params Behavior[] behaviors) where T : VisualElement
        {
            behaviors.ForEach(x => visual.Behaviors.Add(x));
            return visual;
        }

        public static T FlowDirection<T>(this T visual, FlowDirection direction) where T : VisualElement
        {
            visual.FlowDirection = direction;
            return visual;
        }

        public static T HeightRequest<T>(this T visual, double heightRequest) where T : VisualElement
        {
            visual.HeightRequest = heightRequest;
            return visual;
        }

        public static T WidthRequest<T>(this T visual, double widthRequest) where T : VisualElement
        {
            visual.WidthRequest = widthRequest;
            return visual;
        }

        public static T SizeRequest<T>(this T visual, double widthRequest, double heighRequest) where T : VisualElement
        {
            visual.WidthRequest = widthRequest;
            visual.HeightRequest = heighRequest;
            return visual;
        }

        public static T SizeRequest<T>(this T visual, double uniform) where T : VisualElement
        {
            visual.WidthRequest = uniform;
            visual.HeightRequest = uniform;
            return visual;
        }

        public static T Size<T>(this T visual, double uniform) where T : VisualElement
        {
            visual.WidthRequest = uniform;
            visual.HeightRequest = uniform;
            return visual;
        }

        public static T MinimumSizeRequest<T>(this T visual, double widthRequest, double heighRequest) where T : VisualElement
        {
            visual.MinimumWidthRequest = widthRequest;
            visual.MinimumHeightRequest = heighRequest;
            return visual;
        }

        public static T MinimumSizeRequest<T>(this T visual, double uniform) where T : VisualElement
        {
            visual.MinimumWidthRequest = uniform;
            visual.MinimumHeightRequest = uniform;
            return visual;
        }

        public static T InputTransparent<T>(this T visual, bool transparent) where T : VisualElement
        {
            visual.InputTransparent = transparent;
            return visual;
        }

        public static T IsEnabled<T>(this T visual, bool enabled) where T : VisualElement
        {
            visual.IsEnabled = enabled;
            return visual;
        }

        public static T IsVisible<T>(this T visual, bool visible) where T : VisualElement
        {
            visual.IsVisible = visible;
            return visual;
        }

        public static T Opacity<T>(this T visual, double opacity) where T : VisualElement
        {
            visual.Opacity = opacity;
            return visual;
        }

        public static T Resources<T>(this T visual, ResourceDictionary dictionary) where T : VisualElement
        {
            visual.Resources = dictionary;
            return visual;
        }

        public static T Rotate<T>(this T visual, double rotation, double rotateX = 0, double rotateY = 0) where T : VisualElement
        {
            visual.Rotation = rotation;
            visual.RotationX = rotateX;
            visual.RotationY = rotateY;
            return visual;
        }

        public static T Scale<T>(this T visual, double scale) where T : VisualElement
        {
            visual.Scale = scale;
            return visual;
        }

        public static T Style<T>(this T visual, Style style) where T : VisualElement
        {
            visual.Style = style;
            return visual;
        }

        public static T StyleClass<T>(this T visual, Func<IList<string>> styleClass) where T : VisualElement
        {
            styleClass.Invoke().ForEach(x => visual.StyleClass.Add(x));
            return visual;
        }

        public static T StyleClass<T>(this T visual, params string[] styleClass) where T : VisualElement
        {
            styleClass.ForEach(x => visual.StyleClass.Add(x));
            return visual;
        }

        public static T Translate<T>(this T visual, double translateX = 0, double translateY = 0)
            where T : VisualElement
        {
            visual.TranslationX = translateX;
            visual.TranslationY = translateY;
            return visual;
        }

        public static T Triggers<T>(this T visual, Func<IList<TriggerBase>> triggers) where T : VisualElement
        {
            triggers.Invoke().ForEach(x => visual.Triggers.Add(x));
            return visual;
        }

        public static T Triggers<T>(this T visual, params TriggerBase[] triggers) where T : VisualElement
        {
            triggers.ForEach(x => visual.Triggers.Add(x));
            return visual;
        }
    }
}