using System;

namespace Logic.Matrix.Matrixes
{
    public class SquareMatrix<T> : Matrix<T>
        where T : struct 
    {
        public SquareMatrix(int size) : base(size, size) { }

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