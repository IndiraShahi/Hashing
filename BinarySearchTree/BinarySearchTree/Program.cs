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
        }
    }
}
