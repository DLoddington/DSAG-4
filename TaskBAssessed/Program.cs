using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBAssessed.Classes;

namespace TaskBAssessed
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node("ab");
            root.Left = new Node("de");
            root.Right = new Node("bh");
            root.Left.Left = new Node("re");
            root.Right.Left = new Node("vv");
            root.Right.Right = new Node("af");
            root.Left.Left.Left = new Node("ut");
            root.Right.Right.Right = new Node("wa");
            root.Right.Right.Left = new Node("bg");
            BinTree myTree = new BinTree(root);
            string s = "";
            myTree.Largest(ref s);
            Console.WriteLine(s);
            string t = myTree.ancestor("wa", "bg");
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
