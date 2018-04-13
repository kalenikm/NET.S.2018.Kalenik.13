using System;
using System.Collections.Generic;

namespace Logic.BinarySearchTree
{
    public class BinarySearchTree<T>
    {
        private readonly TreeNode<T> _root;
        private readonly IComparer<T> _comparer;

        public BinarySearchTree(T item, IComparer<T> comparer = null)
        {
            if (ReferenceEquals(null, item))
            {
                throw new ArgumentNullException($"{nameof(item)} is null.");
            }

            if (!(item is IComparable<T>) && ReferenceEquals(null, comparer))
            {
                throw new InvalidCastException(
                    $"{nameof(T)} should implement IComparable<T>. Or use comparator.");
            }

            _comparer = comparer;
            _root = new TreeNode<T>(item, null);
        }

        public void Add(T item)
        {
            TreeNode<T> current = _root;
            while (true)
            {
                if (Compare(current.Value, item) < 0)
                {
                    if (ReferenceEquals(null, current.Right))
                    {
                        current.Right = new TreeNode<T>(item, current.Right);
                        break;
                    }
                    current = current.Right;
                }
                else
                {
                    if (ReferenceEquals(null, current.Left))
                    {
                        current.Left = new TreeNode<T>(item, current.Left);
                        break;
                    }
                    current = current.Left;
                }
            }
        }

        public void Add(IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                Add(item);
            }
        }

        private int Compare(T x, T y)
        {
            if (!ReferenceEquals(null, _comparer))
            {
                return _comparer.Compare(x, y);
            }
            return ((IComparable<T>) x).CompareTo(y);
        }

        public IEnumerable<T> Preorder()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(_root);
            while (stack.Count != 0)
            {
                TreeNode<T> current = stack.Pop();

                yield return current.Value;

                if (!ReferenceEquals(null, current.Right))
                    stack.Push(current.Right);
                if (!ReferenceEquals(null, current.Left))
                    stack.Push(current.Left);
            }
        }

        public IEnumerable<T> Inorder()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            TreeNode<T> current = _root;
            while (!ReferenceEquals(null, current) || stack.Count != 0)
            {
                if (stack.Count != 0)
                {
                    current = stack.Pop();

                    yield return current.Value;

                    current = current.Right;
                }
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
            }
        }

        public IEnumerable<T> Postorder()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            TreeNode<T> current = _root;
            while (!ReferenceEquals(null, current) || stack.Count != 0)
            {
                if (stack.Count != 0)
                {
                    current = stack.Pop();
                    if (stack.Count != 0 && ReferenceEquals(current.Right, stack.Peek()))
                    {
                        current = stack.Pop();
                    }
                    else
                    {
                        yield return current.Value;
                        current = null;
                    }
                }
                while (current != null)
                {
                    stack.Push(current);
                    if (current.Right != null)
                    {
                        stack.Push(current.Right);
                        stack.Push(current);
                    }
                    current = current.Left;
                }
            }
        }
    }
}