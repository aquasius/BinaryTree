using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class Node
   {
        //member variables (has a)
        public int data;
        public int level;
        public Node left;
        public Node right;

        //Constructor
       public Node(int data)
       {
         this.data = data;
         left = null;
         right = null;
         level = 0;
       }


        }
}
