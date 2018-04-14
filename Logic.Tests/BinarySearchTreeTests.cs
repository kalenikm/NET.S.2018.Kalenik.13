using System;
using NUnit.Framework;
using Logic.BinarySearchTree;

namespace Logic.Tests
{
    [TestFixture()]
    public class BinarySearchTreeTests
    {
        [Test]
        public void BinarySearchTree_Int32_PreorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(new[] { 8, 10, 3, 2, 7, 6 });
            int[] res = {5, 3, 2, 8, 7, 6, 10};
            int index = 0;
            foreach (var num in tree.Preorder())
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }

        [Test]
        public void BinarySearchTree_Int32_InorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(new[] { 8, 10, 3, 2, 7, 6 });
            int[] res = {2, 3, 5, 6, 7, 8, 10};
            int index = 0;
            foreach (var num in tree.Inorder())
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }

        [Test]
        public void BinarySearchTree_Int32_PostorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(new[] {8, 10, 3, 2, 7, 6});
            int[] res = {2, 3, 6, 7, 10, 8, 5};
            int index = 0;
            foreach (var num in tree.Postorder())
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }
    }
}