using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    //solves the peg board game
    class Solver
    {
        //variables
        Random rgen = new Random();
        int jump; //which peg to jump
        List<int> possJumps; //list of possible jumps
        List<int> possJumpsCopy;
        Node zero, one, two, three, four, five, six, seven,
            eight, nine, ten, eleven, twelve, thirteen,
            fourteen;
        List<Node> listOfNodes;
        string back;
        int count; //used in traverse method
        
        //traverse the board
        public int Traverse()
        {
            zero.IsChecked = false;
            one.IsChecked = false;
            two.IsChecked = false;
            three.IsChecked = false;
            four.IsChecked = false;
            five.IsChecked = false;
            six.IsChecked = false;
            seven.IsChecked = false;
            eight.IsChecked = false;
            nine.IsChecked = false;
            ten.IsChecked = false;
            eleven.IsChecked = false;
            twelve.IsChecked = false;
            thirteen.IsChecked = false;
            fourteen.IsChecked = false;
            count = 0;
            Traverse(zero);
            return count;
        }

        public void Traverse(Node top)
        {
            if (top != null)
            {
                Traverse(top.DownLeft);
                if (top.Full == true && top.IsChecked == false) count++;
                Traverse(top.DownRight);
                top.IsChecked = true;
            }
        }

        //initializes board
        public Solver()
        {
            //set up values
            zero = new Node(0);
            one = new Node(1);
            two = new Node(2);
            three = new Node(3);
            four = new Node(4);
            five = new Node(5);
            six = new Node(6);
            seven = new Node(7);
            eight = new Node(8);
            nine = new Node(9);
            ten = new Node(10);
            eleven = new Node(11);
            twelve = new Node(12);
            thirteen = new Node(13);
            fourteen = new Node(14);
            possJumps = new List<int>();
            possJumpsCopy = new List<int>();
            listOfNodes = new List<Node>();

            //builds board
            zero.UpLeft = null;
            zero.Left = null;
            zero.DownLeft = one;
            zero.DownRight = two;
            zero.Right = null;
            zero.UpRight = null;
            one.UpLeft = null;
            one.Left = null;
            one.DownLeft = three;
            one.DownRight = four;
            one.Right = two;
            one.UpRight = zero;
            two.UpLeft = zero;
            two.Left = one;
            two.DownLeft = four;
            two.DownRight = five;
            two.Right = null;
            two.UpRight = null;
            three.UpLeft = null;
            three.Left = null;
            three.DownLeft = six;
            three.DownRight = seven;
            three.Right = four;
            three.UpRight = one;
            four.UpLeft = one;
            four.Left = three;
            four.DownLeft = seven;
            four.DownRight = eight;
            four.Right = five;
            four.UpRight = two;
            five.UpLeft = two;
            five.Left = four;
            five.DownLeft = eight;
            five.DownRight = nine;
            five.Right = null;
            five.UpRight = null;
            six.UpLeft = null;
            six.Left = null;
            six.DownLeft = ten;
            six.DownRight = eleven;
            six.Right = seven;
            six.UpRight = three;
            seven.UpLeft = three;
            seven.Left = six;
            seven.DownLeft = eleven;
            seven.DownRight = twelve;
            seven.Right = eight;
            seven.UpRight = four;
            eight.UpLeft = four;
            eight.Left = seven;
            eight.DownLeft = twelve;
            eight.DownRight = thirteen;
            eight.Right = nine;
            eight.UpRight = five;
            nine.UpLeft = five;
            nine.Left = eight;
            nine.DownLeft = thirteen;
            nine.DownRight = fourteen;
            nine.Right = null;
            nine.UpRight = null;
            ten.UpLeft = null;
            ten.Left = null;
            ten.DownLeft = null;
            ten.DownRight = null;
            ten.Right = eleven;
            ten.UpRight = six;
            eleven.UpLeft = six;
            eleven.Left = ten;
            eleven.DownLeft = null;
            eleven.DownRight = null;
            eleven.Right = twelve;
            eleven.UpRight = seven;
            twelve.UpLeft = seven;
            twelve.Left = eleven;
            twelve.DownLeft = null;
            twelve.DownRight = null;
            twelve.Right = thirteen;
            twelve.UpRight = eight;
            thirteen.UpLeft = eight;
            thirteen.Left = twelve;
            thirteen.DownLeft = null;
            thirteen.DownRight = null;
            thirteen.Right = fourteen;
            thirteen.UpRight = nine;
            fourteen.UpLeft = nine;
            fourteen.Left = thirteen;
            fourteen.DownLeft = null;
            fourteen.DownRight = null;
            fourteen.Right = null;
            fourteen.UpRight = null;

            //used to find possible moves
            zero.Data = 0;
            one.Data = 1;
            two.Data = 2;
            three.Data = 3;
            four.Data = 4;
            five.Data = 5;
            six.Data = 6;
            seven.Data = 7;
            eight.Data = 8;
            nine.Data = 9;
            ten.Data = 10;
            eleven.Data = 11;
            twelve.Data = 12;
            thirteen.Data = 13;
            fourteen.Data = 14;

            //set up listOfNodes
            listOfNodes.Add(zero);
            listOfNodes.Add(one);
            listOfNodes.Add(two);
            listOfNodes.Add(three);
            listOfNodes.Add(four);
            listOfNodes.Add(five);
            listOfNodes.Add(six);
            listOfNodes.Add(seven);
            listOfNodes.Add(eight);
            listOfNodes.Add(nine);
            listOfNodes.Add(ten);
            listOfNodes.Add(eleven);
            listOfNodes.Add(twelve);
            listOfNodes.Add(thirteen);
            listOfNodes.Add(fourteen);
        }

        //resets all peg values
        public void Reset()
        {
            zero.Full = true;
            one.Full = true;
            two.Full = true;
            three.Full = true;
            four.Full = true;
            five.Full = true;
            six.Full = true;
            seven.Full = true;
            eight.Full = true;
            nine.Full = true;
            ten.Full = true;
            eleven.Full = true;
            twelve.Full = true;
            thirteen.Full = true;
            fourteen.Full = true;
            possJumps.Clear();
            possJumpsCopy.Clear();
            back = "";
            zero.IsChecked = false;
            one.IsChecked = false;
            two.IsChecked = false;
            three.IsChecked = false;
            four.IsChecked = false;
            five.IsChecked = false;
            six.IsChecked = false;
            seven.IsChecked = false;
            eight.IsChecked = false;
            nine.IsChecked = false;
            ten.IsChecked = false;
            eleven.IsChecked = false;
            twelve.IsChecked = false;
            thirteen.IsChecked = false;
            fourteen.IsChecked = false;
        }

        //check to see which peg is empty
        public void Emp(int empty)
        {
            if (empty == 0) zero.Full = false;
            else if (empty == 1) one.Full = false;
            else if (empty == 2) two.Full = false;
            else if (empty == 3) three.Full = false;
            else if (empty == 4) four.Full = false;
            else if (empty == 5) five.Full = false;
            else if (empty == 6) six.Full = false;
            else if (empty == 7) seven.Full = false;
            else if (empty == 8) eight.Full = false;
            else if (empty == 9) nine.Full = false;
            else if (empty == 10) ten.Full = false;
            else if (empty == 11) eleven.Full = false;
            else if (empty == 12) twelve.Full = false;
            else if (empty == 13) thirteen.Full = false;
            else if (empty == 14) fourteen.Full = false;
        }

        //solves the game
        public string Solve(int empty)
        {
            Emp(empty);
            Traverse();

            //main loop, runs until one peg is left, i.e. 13 times
            while (count != 1)
            {
                Traverse();
                possJumps.Clear();
                possJumpsCopy.Clear();

                //check for possible moves
                foreach(Node n in listOfNodes)
                {
                    //search lower right
                    if (n != null && n.Full == true && n.DownRight != null && n.DownRight.Full == true && n.DownRight.DownRight != null && n.DownRight.DownRight.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.DownRight.Data);
                        possJumps.Add(n.DownRight.DownRight.Data);
                    }
                    if (n == null && n.Full == false && n.DownRight != null && n.DownRight.Full == true && n.DownRight.DownRight != null && n.DownRight.DownRight.Full == true) //n is empty
                    {
                        possJumps.Add(n.DownRight.DownRight.Data);
                        possJumps.Add(n.DownRight.Data);
                        possJumps.Add(n.Data);
                    }

                    //search left
                    if (n != null && n.Full == true && n.Left != null && n.Left.Full == true && n.Left.Left != null && n.Left.Left.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.Left.Data);
                        possJumps.Add(n.Left.Left.Data);
                    }
                    if (n == null && n.Full == false && n.Left != null && n.Left.Full == true && n.Left.Left != null && n.Left.Left.Full == true) //n is empty
                    {
                        possJumps.Add(n.Left.Left.Data);
                        possJumps.Add(n.Left.Data);
                        possJumps.Add(n.Data);
                    }

                    //search right
                    if (n != null && n.Full == true && n.Right != null && n.Right.Full == true && n.Right.Right != null && n.Right.Right.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.Right.Data);
                        possJumps.Add(n.Right.Right.Data);
                    }
                    if (n == null && n.Full == false && n.Right != null && n.Right.Full == true && n.Right.Right != null && n.Right.Right.Full == true) //n is empty
                    {
                        possJumps.Add(n.Right.Right.Data);
                        possJumps.Add(n.Right.Data);
                        possJumps.Add(n.Data);
                    }

                    //search lower left
                    if (n != null && n.Full == true && n.DownLeft != null && n.DownLeft.Full == true && n.DownLeft.DownLeft != null && n.DownLeft.DownLeft.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.DownLeft.Data);
                        possJumps.Add(n.DownLeft.DownLeft.Data);
                    }
                    if (n == null && n.Full == false && n.DownLeft != null && n.DownLeft.Full == true && n.DownLeft.DownLeft != null && n.DownLeft.DownLeft.Full == true) //n is empty
                    {
                        possJumps.Add(n.DownLeft.DownLeft.Data);
                        possJumps.Add(n.DownLeft.Data);
                        possJumps.Add(n.Data);
                    }

                    //search upper right
                    if (n != null && n.Full == true && n.UpRight != null && n.UpRight.Full == true && n.UpRight.UpRight != null && n.UpRight.UpRight.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.UpRight.Data);
                        possJumps.Add(n.UpRight.UpRight.Data);
                    }
                    if (n == null && n.Full == false && n.UpRight != null && n.UpRight.Full == true && n.UpRight.UpRight != null && n.UpRight.UpRight.Full == true) //n is empty
                    {
                        possJumps.Add(n.UpRight.UpRight.Data);
                        possJumps.Add(n.UpRight.Data);
                        possJumps.Add(n.Data);
                    }

                    //search upper left
                    if (n != null && n.Full == true && n.UpLeft != null && n.UpLeft.Full == true && n.UpLeft.UpLeft != null && n.UpLeft.UpLeft.Full == false) //n will be moved
                    {
                        possJumps.Add(n.Data);
                        possJumps.Add(n.UpLeft.Data);
                        possJumps.Add(n.UpLeft.UpLeft.Data);
                    }
                    if (n == null && n.Full == false && n.UpLeft != null && n.UpLeft.Full == true && n.UpLeft.UpLeft != null && n.UpLeft.UpLeft.Full == true) //n is empty
                    {
                        possJumps.Add(n.UpLeft.UpLeft.Data);
                        possJumps.Add(n.UpLeft.Data);
                        possJumps.Add(n.Data);
                    }
                }

                if(possJumps.Count == 0)
                {
                    if (count == 1) break;
                    Reset();
                    Emp(empty);
                    continue;
                }
                else
                {
                    //pick which move to make
                    jump = rgen.Next(1, (possJumps.Count / 3) + 1); //takes count of possible moves, divides by 3 to pick one
                    if (jump == 1)
                    {
                        possJumpsCopy.Add(possJumps[0]);
                        possJumpsCopy.Add(possJumps[1]);
                        possJumpsCopy.Add(possJumps[2]);
                    }
                    else if (jump == 2)
                    {
                        possJumpsCopy.Add(possJumps[3]);
                        possJumpsCopy.Add(possJumps[4]);
                        possJumpsCopy.Add(possJumps[5]);
                    }
                    else if (jump == 3)
                    {
                        possJumpsCopy.Add(possJumps[6]);
                        possJumpsCopy.Add(possJumps[7]);
                        possJumpsCopy.Add(possJumps[8]);
                    }
                    else if (jump == 4)
                    {
                        possJumpsCopy.Add(possJumps[9]);
                        possJumpsCopy.Add(possJumps[10]);
                        possJumpsCopy.Add(possJumps[11]);
                    }
                    else if (jump == 5)
                    {
                        possJumpsCopy.Add(possJumps[12]);
                        possJumpsCopy.Add(possJumps[13]);
                        possJumpsCopy.Add(possJumps[14]);
                    }
                    else if (jump == 6)
                    {
                        possJumpsCopy.Add(possJumps[15]);
                        possJumpsCopy.Add(possJumps[16]);
                        possJumpsCopy.Add(possJumps[17]);
                    }
                    else if (jump == 7)
                    {
                        possJumpsCopy.Add(possJumps[18]);
                        possJumpsCopy.Add(possJumps[19]);
                        possJumpsCopy.Add(possJumps[20]);
                    }
                    else if (jump == 8)
                    {
                        possJumpsCopy.Add(possJumps[21]);
                        possJumpsCopy.Add(possJumps[22]);
                        possJumpsCopy.Add(possJumps[23]);
                    }
                    else if (jump == 9)
                    {
                        possJumpsCopy.Add(possJumps[24]);
                        possJumpsCopy.Add(possJumps[25]);
                        possJumpsCopy.Add(possJumps[26]);
                    }
                    else if (jump == 10)
                    {
                        possJumpsCopy.Add(possJumps[27]);
                        possJumpsCopy.Add(possJumps[28]);
                        possJumpsCopy.Add(possJumps[29]);
                    }

                    //make the jump!
                    //peg being moved - peg 1
                    if (possJumpsCopy[0] == 0) zero.Full = false;
                    else if (possJumpsCopy[0] == 1) one.Full = false;
                    else if (possJumpsCopy[0] == 2) two.Full = false;
                    else if (possJumpsCopy[0] == 3) three.Full = false;
                    else if (possJumpsCopy[0] == 4) four.Full = false;
                    else if (possJumpsCopy[0] == 5) five.Full = false;
                    else if (possJumpsCopy[0] == 6) six.Full = false;
                    else if (possJumpsCopy[0] == 7) seven.Full = false;
                    else if (possJumpsCopy[0] == 8) eight.Full = false;
                    else if (possJumpsCopy[0] == 9) nine.Full = false;
                    else if (possJumpsCopy[0] == 10) ten.Full = false;
                    else if (possJumpsCopy[0] == 11) eleven.Full = false;
                    else if (possJumpsCopy[0] == 12) twelve.Full = false;
                    else if (possJumpsCopy[0] == 13) thirteen.Full = false;
                    else if (possJumpsCopy[0] == 14) fourteen.Full = false;

                    //peg being jumped - peg 2
                    if (possJumpsCopy[1] == 0) zero.Full = false;
                    else if (possJumpsCopy[1] == 1) one.Full = false;
                    else if (possJumpsCopy[1] == 2) two.Full = false;
                    else if (possJumpsCopy[1] == 3) three.Full = false;
                    else if (possJumpsCopy[1] == 4) four.Full = false;
                    else if (possJumpsCopy[1] == 5) five.Full = false;
                    else if (possJumpsCopy[1] == 6) six.Full = false;
                    else if (possJumpsCopy[1] == 7) seven.Full = false;
                    else if (possJumpsCopy[1] == 8) eight.Full = false;
                    else if (possJumpsCopy[1] == 9) nine.Full = false;
                    else if (possJumpsCopy[1] == 10) ten.Full = false;
                    else if (possJumpsCopy[1] == 11) eleven.Full = false;
                    else if (possJumpsCopy[1] == 12) twelve.Full = false;
                    else if (possJumpsCopy[1] == 13) thirteen.Full = false;
                    else if (possJumpsCopy[1] == 14) fourteen.Full = false;

                    //spot being filled by peg 1
                    if (possJumpsCopy[2] == 0) zero.Full = true;
                    else if (possJumpsCopy[2] == 1) one.Full = true;
                    else if (possJumpsCopy[2] == 2) two.Full = true;
                    else if (possJumpsCopy[2] == 3) three.Full = true;
                    else if (possJumpsCopy[2] == 4) four.Full = true;
                    else if (possJumpsCopy[2] == 5) five.Full = true;
                    else if (possJumpsCopy[2] == 6) six.Full = true;
                    else if (possJumpsCopy[2] == 7) seven.Full = true;
                    else if (possJumpsCopy[2] == 8) eight.Full = true;
                    else if (possJumpsCopy[2] == 9) nine.Full = true;
                    else if (possJumpsCopy[2] == 10) ten.Full = true;
                    else if (possJumpsCopy[2] == 11) eleven.Full = true;
                    else if (possJumpsCopy[2] == 12) twelve.Full = true;
                    else if (possJumpsCopy[2] == 13) thirteen.Full = true;
                    else if (possJumpsCopy[2] == 14) fourteen.Full = true;

                    //print what happened
                    back += "\r\nFrom: " + possJumpsCopy[0] + " To: " + possJumpsCopy[2];
                }
            } //end of main loop, repeats all code above 13 times for 13 total moves

            return back;
        }
    }
}