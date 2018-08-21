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

        public static T Effects<T>(this T element, Func<IList<Effect>> effects) where T : Element
        {
            effects.Invoke().ForEach(x => element.Effects.Add(x));
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