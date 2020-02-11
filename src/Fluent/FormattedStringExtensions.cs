using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fluent
{
    public static class FormattedStringExtensions
    {
        public static FormattedString Spans(this FormattedString formattedString, Func<IList<Span>> spans)
        {
            spans.Invoke().ForEach(x => formattedString.Spans.Add(x));
            return formattedString;
        }

        public static FormattedString Spans(this FormattedString formattedString, IEnumerable<Span> spans)
        {
            spans.ForEach(x => formattedString.Spans.Add(x));
            return formattedString;
        }

        public static FormattedString Spans(this FormattedString formattedString, params Span[] spans)
        {
            spans.ForEach(x => formattedString.Spans.Add(x));
            return formattedString;
        }
    }
}