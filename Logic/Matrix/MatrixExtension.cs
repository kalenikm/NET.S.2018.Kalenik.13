using System;
using Logic.Matrix.Matrixes;

namespace Logic.Matrix
{
    public static class MatrixExtension
    {
        public static dynamic Add<T>(this Matrix<T> matr1, Matrix<T> matr2, Func<T,T,T> sumFunc)
            where T : struct 
        {
            Check(matr1, matr2);

            return Sum<T>((dynamic)matr1, (dynamic)matr2, sumFunc);
        }

        private static Matrix<T> Sum<T>(Matrix<T> matr1, Matrix<T> matr2, Func<T, T, T> sumFunc)
            where T : struct 
        {
            return new Matrix<T>(AddMatrixes(matr1, matr2, sumFunc));
        }

        private static SquareMatrix<T> Sum<T>(SquareMatrix<T> matr1, SquareMatrix<T> matr2, Func<T, T, T> sumFunc)
            where T : struct
        {
            return new SquareMatrix<T>(AddMatrixes(matr1, matr2, sumFunc));
        }

        private static SymmetricMatrix<T> Sum<T>(SymmetricMatrix<T> matr1, SymmetricMatrix<T> matr2, Func<T, T, T> sumFunc)
            where T : struct
        {
            return new SymmetricMatrix<T>(AddMatrixes(matr1, matr2, sumFunc));
        }

        private static DiagonalMatrix<T> Sum<T>(DiagonalMatrix<T> matr1, DiagonalMatrix<T> matr2, Func<T, T, T> sumFunc)
            where T : struct
        {
            return new DiagonalMatrix<T>(AddMatrixes(matr1, matr2, sumFunc));
        }


        private static T[,] AddMatrixes<T>(Matrix<T> matr1, Matrix<T> matr2, Func<T, T, T> sumFunc)
            where T : struct 
        {
            int rows = matr1.Rows;
            int coloumns = matr1.Coloumns;

            T[,] newMatr = new T[rows,coloumns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumns; j++)
                {
                    newMatr[i, j] = sumFunc(matr1[i, j], matr2[i, j]);
                }
            }
            return newMatr;
        }

        private static void Check<T>(Matrix<T> matr1, Matrix<T> matr2)
            where T : struct 
        {
            if (ReferenceEquals(null, matr1) || ReferenceEquals(null, matr2))
            {
                throw new ArgumentNullException();
            }

            if (!matr1.Rows.Equals(matr2.Rows) || !matr1.Coloumns.Equals(matr2.Coloumns))
            {
                throw new ArgumentException("Matrixes should have same sizes.");
            }
        }
    }
}