using System;

namespace Logic.Matrix.Matrixes
{
    public class SquareMatrix<T> : Matrix<T>
        where T : struct 
    {
        /// <summary>
        /// Creates new square matrix.
        /// </summary>
        /// <param name="size">Number of rows and coloumns.</param>
        public SquareMatrix(int size) : base(size, size) { }

        /// <summary>
        /// Creates new square matrix from <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Basic array. Should be square.</param>
        public SquareMatrix(T[,] array) : base(array) { }

        protected override void CheckArray(T[,] array)
        {
            base.CheckArray(array);

            if (!array.GetLength(0).Equals(array.GetLength(1)))
            {
                throw new ArgumentException($"{nameof(array)} matrix is not square.");
            }
        }
    }
}