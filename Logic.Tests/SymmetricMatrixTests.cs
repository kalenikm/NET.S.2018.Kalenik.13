using System;
using Logic.Matrix;
using Logic.Matrix.Matrixes;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class SymmetricMatrixTests
    {
        [Test]
        public void SymmetricMatrixCtor_NegativeSize_Exception()
        {
            Assert.Catch<ArgumentException>(() => new SymmetricMatrix<int>(-10));
        }

        [Test]
        public void SymmetricMatrixCtor_NotSquareMatrix_Exception()
        {
            Assert.Catch<ArgumentException>(() => new SymmetricMatrix<int>(new int[3, 5]));
        }

        [Test]
        public void SymmetricMatrixCtor_NotSymmetricMatrix_Exception()
        {
            int[,] matr = new int[3, 3]
            {
                {0, 1, 5},
                {1, 0, 3},
                {4, 3, 0}
            };

            Assert.Catch<ArgumentException>(() => new SymmetricMatrix<int>(matr));
        }

        [Test]
        public void SymmetricMatrixCtor_MormalSize()
        {
            SymmetricMatrix<int> matr = new SymmetricMatrix<int>(3);

            string res = "0 0 0 \n0 0 0 \n0 0 0 \n";
            Assert.AreEqual(res, matr.ToString());
        }

        [Test]
        public void SymmetricMatrixCtor_MormalSymmetricMatrix()
        {
            int[,] matr = new int[3, 3]
            {
                {0, 1, 2},
                {1, 0, 3},
                {2, 3, 0}
            };

            SymmetricMatrix<int> symmatr = new SymmetricMatrix<int>(matr);

            string res = "0 1 2 \n1 0 3 \n2 3 0 \n";
            Assert.AreEqual(res, symmatr.ToString());
        }

        [Test]
        public void SymmetricMatrix_ChangeElement_NormalIndexes()
        {
            int[,] matr = new int[3, 3]
            {
                {0, 1, 2},
                {1, 0, 3},
                {2, 3, 0}
            };

            SymmetricMatrix<int> symmatr = new SymmetricMatrix<int>(matr);

            symmatr[1, 2] = 9;

            Assert.AreEqual(9, symmatr[1, 2]);
            Assert.AreEqual(9, symmatr[2, 1]);
        }
    }
}