using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class ElementExtensions
    {
        public static T AutomationId<T>(this T element, string id) where T : Element
        {
            element.AutomationId = id;
            return element;
        }

        public static T ClassId<T>(this T element, string id) where T : Element
        {
            element.ClassId = id;
            return element;
        }

        public static T Effects<T>(this T element, IList<Effect> effects) where T : Element
        {
            if (effects is null)
                throw new ArgumentNullException();

            effects.ForEach(e => element.Effects.Add(e));
            return element;
        }

        public static T Effects<T>(this T element, Func<IList<Effect>> effects) where T : Element
        {
            if (effects is null)
                throw new ArgumentNullException();

            effects.Invoke().ForEach(x => AddEffect(element, x));
            return element;
        }

        public static T Effects<T>(this T element, params Effect[] effects) where T : Element
        {
            if (effects is null)
                throw new ArgumentNullException();

            effects.ForEach(x => AddEffect(element, x));
            return element;
        }

        public static T AddEffect<T>(this T element, Effect effect) where T : Element
        {
            if (effect is null)
                return element;

            element.Effects.Add(effect);
            return element;
        }

        public static T Parent<T>(this T element, Element parent) where T : Element
        {
            element.Parent = parent;
            return element;
        }

        public static T StyleId<T>(this T element, string id) where T : Element
        {
            element.StyleId = id;
            return element;
        }
    }
}