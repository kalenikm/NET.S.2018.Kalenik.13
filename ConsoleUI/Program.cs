using System;
using Logic;
using Logic.BinarySearchTree;
using Logic.Comparers;
using Logic.Matrix;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> intTree = new BinarySearchTree<int>(5);
            intTree.Add(new[] {8, 10, 3, 2, 7, 6});
            foreach (var item in intTree.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BinarySearchTree<int> intTree2 = new BinarySearchTree<int>(5, new IntComparer());
            intTree2.Add(new[] { 8, 10, 3, 2, 7, 6 });
            foreach (var item in intTree2.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BinarySearchTree<string> stringTree = new BinarySearchTree<string>("5");
            stringTree.Add(new[] { "8", "9", "3", "2", "7", "6" });
            foreach (var item in stringTree.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BinarySearchTree<string> stringTree2 = new BinarySearchTree<string>("5", new Logic.Comparers.StringComparer());
            stringTree2.Add(new[] { "8", "9", "3", "2", "7", "6" });
            foreach (var item in stringTree2.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            BinarySearchTree<Book> bookTree = new BinarySearchTree<Book>(new Book("Aaa", "Bbb", 102));
            bookTree.Add(new [] {new Book("Ccc", "Aaa", 1356), new Book("Zzz", "Qqq", 803), new Book("Lll", "Bbb", 1234)});
            foreach (var item in bookTree.Inorder())
            {
                Console.Write("\"{0}\", {1}, {2}.  ", item.Title, item.Author, item.Pages);
            }
            Console.WriteLine();

            BinarySearchTree<Book> bookTree2 = new BinarySearchTree<Book>(new Book("Aaa", "Bbb", 102), new BookComparer());
            bookTree2.Add(new[] { new Book("Ccc", "Aaa", 1356), new Book("Zzz", "Qqq", 803), new Book("Lll", "Bbb", 1234) });
            foreach (var item in bookTree2.Inorder())
            {
                Console.Write("\"{0}\", {1}, {2}.  ", item.Title, item.Author, item.Pages);
            }
            Console.WriteLine();

            BinarySearchTree<Point> pointTree = new BinarySearchTree<Point>(new Point(10,12), new PointComparer());
            pointTree.Add(new[] {new Point(10,6), new Point(11, 2), new Point(94,1), new Point(5,11), new Point(99,0)});
            foreach (var item in pointTree.Inorder())
            {
                Console.Write("X:{0}; Y:{1}.   ", item.X, item.Y);
            }
            Console.WriteLine();
        }
    }
}
