using System;
using NUnit.Framework;
using Logic.BinarySearchTree;

namespace Logic.Tests
{
    [TestFixture()]
    public class BinarySearchTreeTests
    {
        [Test]
        public void BinarySearchTree_PreorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(8);
            tree.Add(10);
            tree.Add(3);
            tree.Add(2);
            tree.Add(7);
            tree.Add(6);
            int[] res = {5, 3, 2, 8, 7, 6, 10};
            int index = 0;
            foreach (var num in tree.Preorder())
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }

        [Test]
        public void BinarySearchTree_InorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(8);
            tree.Add(10);
            tree.Add(3);
            tree.Add(2);
            tree.Add(7);
            tree.Add(6);
            int[] res = {2, 3, 5, 6, 7, 8, 10};
            int index = 0;
            foreach (var num in tree.Inorder())
            {
                Assert.AreEqual(res[index], num);
                index++;
            }
        }

        [Test]
        public void BinarySearchTree_PostorderMethod()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(5);
            tree.Add(8);
            tree.Add(10);
            tree.Add(3);
            tree.Add(2);
            tree.Add(7);
            tree.Add(6);
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