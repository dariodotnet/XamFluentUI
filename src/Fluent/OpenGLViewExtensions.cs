namespace Fluent
{
    using System;
    using Xamarin.Forms;

    public static class OpenGLViewExtensions
    {
        public static OpenGLView HasRenderLoop(this OpenGLView view, bool loop)
        {
            view.HasRenderLoop = loop;
            return view;
        }

        public static OpenGLView OnDisplay(this OpenGLView view, Action<Rectangle> rectangle)
        {
            view.OnDisplay = rectangle;
            return view;
        }
    }
}