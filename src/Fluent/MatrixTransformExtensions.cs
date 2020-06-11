namespace Fluent
{
    using Xamarin.Forms.Shapes;

    public static class MatrixTransformExtensions
    {
        public static MatrixTransform Matrix(this MatrixTransform transform, Matrix matrix)
        {
            transform.Matrix = matrix;
            return transform;
        }
    }
}