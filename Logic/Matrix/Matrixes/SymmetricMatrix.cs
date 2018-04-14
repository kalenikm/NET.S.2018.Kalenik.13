using System;

namespace Logic.Matrix.Matrixes
{
    public class SymmetricMatrix<T> : SquareMatrix<T>
        where T : struct 
    {
        /// <summary>
        /// Creates new symmetic matrix.
        /// </summary>
        /// <param name="size">Number of rows and coloumns.</param>
        public SymmetricMatrix(int size) : base(size) { }

        /// <summary>
        /// Creates new symmetric matrix from <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Basic array. Should be symmetric.</param>
        public SymmetricMatrix(T[,] array) : base(array) { }

        protected override void CheckArray(T[,] array)
        {
            base.CheckArray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (!array[i, j].Equals(array[j, i]))
                    {
                        throw new ArgumentException($"{nameof(array)} is not symmetric.");
                    }
                }
            }
        }

        protected override void SetElement(int i, int j, T value)
        {
            base.SetElement(i, j, value);
            base.SetElement(j, i, value);
            Console.WriteLine("lol");
        }
    }
}