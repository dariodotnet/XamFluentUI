using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class VisualStateGroupExtensions
    {
        public static VisualStateGroup Name(this VisualStateGroup visual, string name)
        {
            visual.Name = name;
            return visual;
        }

        public static VisualStateGroup States(this VisualStateGroup visual, IList<VisualState> states)
        {
            states.ForEach(state => visual.States.Add(state));
            return visual;
        }

        public static VisualStateGroup States(this VisualStateGroup visual, Func<IList<VisualState>> states)
        {
            states.Invoke().ForEach(state => visual.States.Add(state));
            return visual;
        }

        public static VisualStateGroup TargetType(this VisualStateGroup visual, Type type)
        {
            visual.TargetType = type;
            return visual;
        }
    }
}