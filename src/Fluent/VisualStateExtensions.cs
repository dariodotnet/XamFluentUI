using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class VisualStateExtensions
    {
        public static VisualState Name(this VisualState visual, string name)
        {
            visual.Name = name;
            return visual;
        }

        public static VisualState Setters(this VisualState visual, IList<Setter> setters)
        {
            setters.ForEach(s => visual.Setters.Add(s));
            return visual;
        }

        public static VisualState Setters(this VisualState visual, Func<IList<Setter>> setters)
        {
            setters.Invoke().ForEach(s => visual.Setters.Add(s));
            return visual;
        }

        public static VisualState Setters(this VisualState visual, params Setter[] setters)
        {
            setters.ForEach(s => visual.Setters.Add(s));
            return visual;
        }

        public static VisualState TargetType(this VisualState visual, Type type)
        {
            visual.TargetType = type;
            return visual;
        }
    }
}