using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAAssessed.Classes
{
    class Node
    {
        private int data;
        public Node Left, Right;

        public Node(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public int Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}
