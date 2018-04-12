using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class CustomIterator<T> : IEnumerator<T>, IEnumerator
    {
        private readonly T[] _array;
        private int _index;
        private readonly int _count;

        public CustomIterator(T[] array)
        {
            _array = array;
            _index = -1;
            _count = _array.Length;
        }

        object IEnumerator.Current
        {
            get
            {
                if(_index >= _count - 1)
                    throw new ArgumentException();
                return _array[_index];
            }
        }

        public T Current
        {
            get
            {
                if (_index >= _count - 1)
                    throw new ArgumentException();
                return _array[_index];
            }
        }

        public bool MoveNext()
        {
            return ++_index < _count - 1;
        }

        public void Reset()
        {
            _index = -1;
        }

        public void Dispose()
        {
            
        }
    }
}