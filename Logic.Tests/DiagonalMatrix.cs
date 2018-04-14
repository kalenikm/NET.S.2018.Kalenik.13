using System;
using Logic.Matrix;
using NUnit.Framework;

namespace Logic.Tests
{
    public class DiagonalMatrix
    {
        [TestFixture]
        public class SquareMatrixTests
        {
            [Test]
            public void DiagonalMatrixCtor_NegativeSize_Exception()
            {
                Assert.Catch<ArgumentException>(() => new DiagonalMatrix<int>(-10));
            }

            [Test]
            public void DiagonalMatrixCtor_NotSquareMatrix_Exception()
            {
                Assert.Catch<ArgumentException>(() => new DiagonalMatrix<int>(new int[3, 5]));
            }

            [Test]
            public void DiagonalMatrixCtor_MormalSize()
            {
                DiagonalMatrix<int> matr = new DiagonalMatrix<int>(3);

                string res = "0 0 0 \n0 0 0 \n0 0 0 \n";
                Assert.AreEqual(res, matr.ToString());
            }

            [Test]
            public void DiagonalMatrixCtor_MormalDiagonalMatrix()
            {
                int[,] matr = new int[3, 3]
                {
                    {0, 2, 4},
                    {1, 0, 2},
                    {9, 5, 0}
                };

                DiagonalMatrix<int> sqmatr = new DiagonalMatrix<int>(matr);

                string res = "0 2 4 \n1 0 2 \n9 5 0 \n";
                Assert.AreEqual(res, sqmatr.ToString());
            }

            [Test]
            public void DiagonalMatrixCtor_SetElementOnDiagonal_Exception()
            {
                DiagonalMatrix<int> dmatr = new DiagonalMatrix<int>(3);
                Assert.Catch<ArgumentException>(() => dmatr[2, 2] = 10);
            }
        }
    }
}