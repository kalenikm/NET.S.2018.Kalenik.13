using System;

namespace Logic.Matrix.Matrixes
{
    public delegate void OnChangeEvent<T>(object sender, OnChangeEventArgs args)
        where T : struct;

    public class Matrix<T>
        where T : struct 
    {
        protected T[,] _array;

        public int Rows => _array.GetLength(0);
        public int Coloumns => _array.GetLength(1);

        public Matrix(int size1, int size2)
        {
            if (size1 < 0 || size2 < 0)
            {
                throw new ArgumentException("Size of matrix can't be negative.");
            }

            _array = new T[size1, size2];
        }

        public Matrix(T[,] array)
        {
            CheckArray(array);

            _array = array;
        }

        public event OnChangeEvent<T> OnChange;

        public T this[int i, int j]
        {
            get
            {
                CheckIndexes(i, j);

                return _array[i, j];
            }
            set
            {
                CheckIndexes(i, j);

                T old = this[i, j];
               
                this.SetElement(i, j, value);

                OnChange?.Invoke(this, new OnChangeEventArgs(i, j, old, value));
            }
        }

        public override string ToString()
        {
            string res = String.Empty;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Coloumns; j++)
                {
                    res += _array[i, j] + " ";
                }
                res += "\n";
            }

            return res;
        }

        protected virtual void SetElement(int i, int j, T value)
        {
            _array[i, j] = value;
        }

        protected void CheckIndexes(int i, int j)
        {
            if (i < 0 || j < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (_array.GetLength(0) <= i && _array.GetLength(1) <= j)
            {
                throw new IndexOutOfRangeException();
            }
        }

        protected virtual void CheckArray(T[,] array)
        {
            if (ReferenceEquals(null, array))
            {
                throw new ArgumentNullException($"{nameof(array)} is null.");
            }
        }
    }
}