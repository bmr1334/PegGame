using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //node for board game
    class Node
    {
        //variables
        Node left;
        Node right;
        Node upLeft;
        Node upRight;
        Node downLeft;
        Node downRight;
        int data;
        bool full; //true if spot has a peg, false if spot is empty
        bool isChecked; //prevents double checking

        //constructor to set default values
        public Node(int num)
        {
            data = num;
            left = null;
            right = null;
            upLeft = null;
            upRight = null;
            downLeft = null;
            downRight = null;
            full = true;
            isChecked = false;
        }

        //properties
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
        public Node UpRight
        {
            get { return upRight; }
            set { upRight = value; }
        }
        public Node UpLeft
        {
            get { return upLeft; }
            set { upLeft = value; }
        }
        public Node DownRight
        {
            get { return downRight; }
            set { downRight = value; }
        }
        public Node DownLeft
        {
            get { return downLeft; }
            set { downLeft = value; }
        }
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public bool Full
        {
            get { return full; }
            set { full = value; }
        }
    }
}
