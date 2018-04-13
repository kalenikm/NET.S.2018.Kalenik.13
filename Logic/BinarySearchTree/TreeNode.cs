namespace Logic.BinarySearchTree
{
    public class TreeNode<T>
    {
        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public T Value { get; set; }

        public TreeNode()
        {
            Parent = null;
            Left = null;
            Right = null;
            Value = default(T);
        }

        public TreeNode(T item, TreeNode<T> parent)
        {
            Value = item;
            Parent = parent;
        }
    }
}