using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class VisualElementExtensions
    {
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

        public static T MinimumSizeRequest<T>(this T visual, double widthRequest, double heighRequest) where T : VisualElement
        {
            visual.MinimumWidthRequest = widthRequest;
            visual.MinimumHeightRequest = heighRequest;
            return visual;
        }

        public static T Opacity<T>(this T visual, double opacity) where T : VisualElement
        {
            visual.Opacity = opacity;
            return visual;
        }

        public static T Rotate<T>(this T visual, double rotation, double rotateX = 0, double rotateY = 0) where T : VisualElement
        {
            visual.Rotation = rotation;
            visual.RotationX = rotateX;
            visual.RotationY = rotateY;
            return visual;
        }

        public static T Style<T>(this T visual, Style style) where T : VisualElement
        {
            visual.Style = style;
            return visual;
        }

        public static T Translate<T>(this T visual, double translateX = 0, double translateY = 0)
            where T : VisualElement
        {
            visual.TranslationX = translateX;
            visual.TranslationY = translateY;
            return visual;
        }
    }
}