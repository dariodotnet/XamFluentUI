using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    using System;
    using System.Linq;

    public static class StyleExtensions
    {
        public static Style ApplyToDerivedTypes(this Style style, bool apply)
        {
            style.ApplyToDerivedTypes = apply;
            return style;
        }

        public static Style BasedOn(this Style style, Style reference)
        {
            style.BasedOn = reference;
            return style;
        }

        public static Style BaseResourceKey(this Style style, string key)
        {
            style.BaseResourceKey = key;
            return style;
        }

        public static Style Behaviors(this Style style, IList<Behavior> behaviors)
        {
            if (behaviors is null)
                throw new ArgumentNullException();

            behaviors.ForEach(b => style.Behaviors.Add(b));
            return style;
        }

        public static Style Behaviors(this Style style, Func<IList<Behavior>> behaviors)
        {
            if (behaviors is null)
                throw new ArgumentNullException();

            behaviors.Invoke().ForEach(b => style.Behaviors.Add(b));
            return style;
        }

        public static Style Behaviors(this Style style, params Behavior[] behaviors)
        {
            if (behaviors is null)
                throw new ArgumentNullException();

            behaviors.ForEach(b => style.Behaviors.Add(b));
            return style;
        }

        public static Style CanCascade(this Style style, bool canCascade)
        {
            style.CanCascade = canCascade;
            return style;
        }

        public static Style Class(this Style style, string id)
        {
            style.Class = id;
            return style;
        }

        public static Style Setters(this Style style, IList<Setter> setters)
        {
            if (setters is null)
                throw new ArgumentNullException();

            setters.ForEach(s => style.Setters.Add(s));
            return style;
        }

        public static Style Setters(this Style style, Func<IList<Setter>> setters)
        {
            if (setters is null)
                throw new ArgumentNullException();

            setters.Invoke().ForEach(s => style.Setters.Add(s));
            return style;
        }

        public static Style Setters(this Style style, params (BindableProperty property, object value)[] setters)
        {
            return Setters(style, setters.Select(x => new Setter().Property(x.property, x.value)).ToArray());
        }

        public static Style Setters(this Style style, params Setter[] setters)
        {
            if (setters is null)
                throw new ArgumentNullException();

            setters.ForEach(s => style.Setters.Add(s));
            return style;
        }

        public static Style Triggers(this Style style, IList<Trigger> triggers)
        {
            if (triggers is null)
                throw new ArgumentNullException();

            triggers.ForEach(t => style.Triggers.Add(t));
            return style;
        }

        public static Style Triggers(this Style style, Func<IList<Trigger>> triggers)
        {
            if (triggers is null)
                throw new ArgumentNullException();

            triggers.Invoke().ForEach(t => style.Triggers.Add(t));
            return style;
        }

        public static Style Triggers(this Style style, params Trigger[] triggers)
        {
            if (triggers is null)
                throw new ArgumentNullException();

            triggers.ForEach(t => style.Triggers.Add(t));
            return style;
        }
    }
}