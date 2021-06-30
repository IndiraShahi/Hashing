using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable 
    {                                         
        Node<T> Root;
        Node<T> Current;
        
        public void InsertData(T data)
        {
           
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                return;
            }
            
            if (this.Current.data.CompareTo(data) > 0)
            {
                
                if (this.Current.leftNode == null)
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;

                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
                Console.WriteLine("{0} Left Node value ", data);
            }
            else
            {
                ///Checks if right node is null.
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
                Console.WriteLine("{0} Right Node value ", data);
            }

        }
        
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Numbers in binary tree: " + node.data);
                Display(node.rightNode);
            }

        }
    }
}