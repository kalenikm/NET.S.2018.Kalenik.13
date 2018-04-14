using System;

namespace Logic.Matrix.Matrixes
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
        where T : struct 
    {
        /// <summary>
        /// Creates new diagonal matrix
        /// </summary>
        /// <param name="size">Number of rows and coloumns.</param>
        public DiagonalMatrix(int size) : base(size) { }

        /// <summary>
        /// Creates new diagonal matrix from <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Basic array. Should be diagonal.</param>
        public DiagonalMatrix(T[,] array) : base(array) { }

        protected override void CheckArray(T[,] array)
        {
            base.CheckArray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (!array[i, i].Equals(default(T)))
                {
                    throw new ArgumentException($"{nameof(array)} is not diagonal.");
                }
            }
        }

        protected override void SetElement(int i, int j, T value)
        {
            if (i.Equals(j))
            {
                throw new ArgumentException("Diagonal always has default value in diagonal matrix.");
            }

            base.SetElement(i, j, value);
        }
    }
}