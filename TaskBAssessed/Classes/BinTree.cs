using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBAssessed.Classes
{
    class BinTree
    {
        private Node root;
        public BinTree()
        {
            root = null;
        }

        public BinTree(Node node)
        {
            root = node;
        }

        public string Largest(ref string s)
        {
            return largest(root, ref s);
        }

        private string largest(Node n, ref string s)
        {
            if (n != null)
            {
                largest(n.Left, ref s);
                largest(n.Right, ref s);
                if (s.CompareTo(n.Data) < 0)
                    s = n.Data;
                return s;
            }
            else
                return s;
        }

        private bool Find(string s)
        {
            return find(s, root);
        }

        private bool find(string s, Node tree)
        {
            if (tree != null)
            {
                if (s.CompareTo(tree.Data) == 0)
                    return true;
                else
                    return find(s, tree.Left) || find(s, tree.Right);
            }
            else
                return false;
        }

        private Node FindAncestor(string s, string t)
        {
            return findAncestor(root, s, t);
        }

        private Node findAncestor(Node tree, string s, string t)
        {
            if (tree == null)
                return null;
            if (tree.Data.CompareTo(s) == 0 || tree.Data.CompareTo(t) == 0)
                return tree;
            Node n = findAncestor(tree.Left, s, t);
            Node o = findAncestor(tree.Right, s, t);
            if(n == null && o == null)
                return null;
            if (n != null && o != null)
                return tree;
            if(n != null)
                return n;
            else
                return o;
        }

        public string ancestor(string s, string t)
        {
            if (Find(s) == true && Find(t) == true)
            { 
                Node n = FindAncestor(s, t);
                return "The first common ancestor of " + s + " and " + t + " is " + n.Data;
            }
            else if(Find(s) == false)
                return s + " cannot be found in the Binary Tree";
            else
                return t + " cannot be found in the Binary Tree";
        }
    }
}
