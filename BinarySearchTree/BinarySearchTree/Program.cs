using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to binary search tree algorithm");
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.InsertData(56);
            tree.InsertData(30);
            tree.InsertData(70);
            tree.Display(tree.GetRoot());

            tree.InsertData(22);
            tree.InsertData(40);
            tree.InsertData(11);
            tree.InsertData(3);
            tree.InsertData(16);
            tree.InsertData(60);
            tree.InsertData(95);
            tree.InsertData(65);
            tree.InsertData(63);
            tree.InsertData(67);
            tree.Display(tree.GetRoot());
            Console.WriteLine(" Total of elements in Binary search tree is: " + tree.GetSize());
            bool result = tree.SearchTree(63, tree.GetRoot());
            Console.WriteLine("Result is " + result);
        }
    }
}
