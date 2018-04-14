using System;

namespace Logic.Matrix
{
    public class SymmetricMatrix<T> : SquareMatrix<T>
        where T : struct 
    {
        public SymmetricMatrix(int size) : base(size) { }
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