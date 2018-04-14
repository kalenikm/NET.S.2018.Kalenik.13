using System;

namespace Logic.BinarySearchTree
{
    public class TreeNode<T>
    {
        #region Properties

        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public T Value { get; set; }

        #endregion

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="item">Value of this node.</param>
        /// <param name="parent">Parent of this node.</param>
        public TreeNode(T item, TreeNode<T> parent)
        {
            if (ReferenceEquals(null, item))
            {
                throw new ArgumentNullException($"{nameof(item)} is null.");
            }

            Value = item;
            Parent = parent;
        }
    }
}