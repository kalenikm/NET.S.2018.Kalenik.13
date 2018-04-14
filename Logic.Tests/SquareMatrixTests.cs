using System;
using Logic.Matrix;
using Logic.Matrix.Matrixes;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class SquareMatrixTests
    {
        [Test]
        public void SquareMatrixCtor_NegativeSize_Exception()
        {
            Assert.Catch<ArgumentException>(() => new SquareMatrix<int>(-10));
        }

        [Test]
        public void SquareMatrixCtor_NotSquareMatrix_Exception()
        {
            Assert.Catch<ArgumentException>(() => new SquareMatrix<int>(new int[3, 5]));
        }

        [Test]
        public void SquareMatrixCtor_MormalSize()
        {
            SquareMatrix<int> matr = new SquareMatrix<int>(3);

            string res = "0 0 0 \n0 0 0 \n0 0 0 \n";
            Assert.AreEqual(res, matr.ToString());
        }

        [Test]
        public void SquareMatrixCtor_MormalSquareMatrix()
        {
            int[,] matr = new int[3,3];
            SquareMatrix<int> sqmatr = new SquareMatrix<int>(matr);

            string res = "0 0 0 \n0 0 0 \n0 0 0 \n";
            Assert.AreEqual(res, sqmatr.ToString());
        }
    }
}