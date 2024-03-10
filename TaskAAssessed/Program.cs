using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAAssessed.Classes;

namespace TaskAAssessed
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(3);
            root.Left = new Node(1);
            root.Right = new Node(2);
            root.Left.Left = new Node(4);
            root.Right.Left = new Node(5);
            root.Right.Right = new Node(6);
            BinTree myTree = new BinTree(root);
            string s = "";
            myTree.InOrder(ref s);
            string t = "";
            myTree.PreOrder(ref t);
            string u = "";
            myTree.PostOrder(ref u);
            Console.WriteLine("InOrder: " + s);
            Console.WriteLine("PreOrder: " + t);
            Console.WriteLine("PostOrder: " + u);
            Console.ReadKey();
        }
    }
}
