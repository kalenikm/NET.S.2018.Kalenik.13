﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class GenericQueue<T> : IEnumerable<T>, IEnumerable
    {
        private T[] _array;
        private int _count;
        private int _head;
        private int _tail;

        public int Count => _count;

        public GenericQueue() : this(8)
        {
        }

        public GenericQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Wrong capacity.");
            }

            _count = 0;
            _head = 0;
            _tail = 0;
            _array = new T[capacity];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] newArray = new T[_count];
            if (_tail > _head)
            {
                Array.Copy(_array, _head, newArray, 0, _count);
            }
            else
            {
                Array.Copy(_array, _head, newArray, 0, _count - _head);
                Array.Copy(_array, 0, newArray, _count - _head, _tail);
            }
            return new CustomIterator<T>(newArray);
        }

        public void Enqueue(T item)
        {
            if (_count >= _array.Length)
            {
                SetCapacity(_array.Length + 8);
            }

            _array[_tail] = item;
            _tail = (_tail + 1) % _array.Length;
            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new EmptyQueueException();
            }

            T item = _array[_head];
            _array[_head] = default(T);
            _head = (_head + 1) % _array.Length;
            _count--;
            return item;
        }

        public void SetCapacity(int size)
        {
            if (_tail > _head)
            {
                T[] newArray = new T[size];
                _array.CopyTo(newArray, 0);
                _array = newArray;
            }
            else
            {
                T[] newArray = new T[size];
                Array.Copy(_array, _head, newArray, 0, _count - _head);
                Array.Copy(_array, 0, newArray, _count - _head, _tail);
                _array = newArray;
            }
            _head = 0;
            _tail = _count;
        }
    }
}