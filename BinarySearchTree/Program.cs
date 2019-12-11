using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BST = new BinaryTree();
            BST.Add(30);
            BST.Add(12);
            BST.Add(47);
            BST.Add(66);
            BST.Add(28);
            BST.Add(10);
            BST.Add(59);
            BST.Add(41);
            BST.Add(60);


            bool result = BST.Search(24);
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
