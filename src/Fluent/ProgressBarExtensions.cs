using Xamarin.Forms;

namespace Fluent
{
    public static class ProgressBarExtensions
    {
        public static ProgressBar Progress(this ProgressBar progressBar, double progress)
        {
            progressBar.Progress = progress;
            return progressBar;
        }

        public static ProgressBar ProgressColor(this ProgressBar progressBar, Color color)
        {
            progressBar.ProgressColor = color;
            return progressBar;
        }
    }
}