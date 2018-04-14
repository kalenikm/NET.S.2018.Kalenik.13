using System;

namespace Logic.Matrix
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
        where T : struct 
    {
        public DiagonalMatrix(int size) : base(size) { }
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