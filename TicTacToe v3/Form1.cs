//Please note: This application is purely for my own education, to run through coding 
//examples by following tutorials, and to just tinker around with coding.  
//I know it’s bad practice to heavily comment code (code smell), but comments in all of my 
//exercises will largely be left intact as this serves me 2 purposes:
//    I want to retain what my original thought process was at the time
//    I want to be able to look back in 1..5..10 years to see how far I’ve come
//    And I enjoy commenting on things, however redundant this may be . . . 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        // True will = X turn, False will = O turn
        bool turn = true;
        int turnCount = 0;
        bool against_computer = false;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Justin", "Tic-Tac-Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;

            turnCount++;

            checkForWinner();

            if ((!turn) && (against_computer))
            {
                computer_make_move();
            }
        }// End buttonClick

        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            try
            {
                move.PerformClick();
            }
            catch { }
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (a1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (a3.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (c3.Text == "")
                    return c3;
                if (c1.Text == "")
                    return c1;
            }

            if (c3.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c1.Text == "")
                    return c1;
            }

            if (c1.Text == "O")
            {
                if (a1.Text == "")
                    return a3;
                if (a3.Text == "")
                    return a3;
                if (c3.Text == "")
                    return c3;
            }

            if (a1.Text == "")
                return a1;
            if (a3.Text == "")
                return a3;
            if (c1.Text == "")
                return c1;
            if (c3.Text == "")
                return c3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a2.Text == mark) && (a3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (a3.Text == mark) && (a2.Text == ""))
                return a2;

            if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b2.Text == mark) && (b3.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c2.Text == mark) && (c3.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c1.Text == mark) && (c3.Text == mark) && (c2.Text == ""))
                return c2;

            //VERTICAL TESTS
            if ((a1.Text == mark) && (b1.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b1.Text == mark) && (c1.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c1.Text == mark) && (b1.Text == ""))
                return b1;

            if ((a2.Text == mark) && (b2.Text == mark) && (c2.Text == ""))
                return c2;
            if ((b2.Text == mark) && (c2.Text == mark) && (a2.Text == ""))
                return a2;
            if ((a2.Text == mark) && (c2.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b3.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b3.Text == mark) && (c3.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c3.Text == mark) && (b3.Text == ""))
                return b3;

            //DIAGONAL TESTS
            if ((a1.Text == mark) && (b2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((b2.Text == mark) && (c3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (c3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((a3.Text == mark) && (b2.Text == mark) && (c1.Text == ""))
                return c1;
            if ((b2.Text == mark) && (c1.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (c1.Text == mark) && (b2.Text == ""))
                return b2;

            return null;
        }

        private void checkForWinner()
        {
            bool thereIsAWinner = false;

            #region Victory Conditions Checks
            // Horizontal checks
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                thereIsAWinner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                thereIsAWinner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                thereIsAWinner = true;

            // Vertical checks
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                thereIsAWinner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!b2.Enabled))
                thereIsAWinner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!c3.Enabled))
                thereIsAWinner = true;

            // Horizontal checks
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                thereIsAWinner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                thereIsAWinner = true;
            #endregion

            if (thereIsAWinner)
            {
                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = textBoxP2.Text;
                    oWinsTotal.Text = (Int32.Parse(oWinsTotal.Text) + 1).ToString();
                }
                else
                {
                    winner = textBoxP1.Text;
                    xWinsTotal.Text = (Int32.Parse(xWinsTotal.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "Good Job!");
                newGameToolStripMenuItem.PerformClick();

            }// End if(thereIsAWinner)
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Bummer...");
                    newGameToolStripMenuItem.PerformClick();
                    drawsTotal.Text = (Int32.Parse(drawsTotal.Text) + 1).ToString();
                }
            }
        }// End checkForWinner

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }// Catch the unhandled exception (trying to cast the menustrip as a button)
            }

        }// End disableButtons()

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }// End foreach
            draws.Focus();
        }

        private void mouseEnterButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }// End if
        }// End mouseEnterButton

        private void mouseLeaveButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }// End if
        }

        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }// End foreach

            oWinsTotal.Text = "0";
            xWinsTotal.Text = "0";
            drawsTotal.Text = "0";
            draws.Focus();
        }

        private void textBoxP2_TextChanged(object sender, EventArgs e)
        {
            // ToUpper compares the text no matter the case it was written in
            if (textBoxP2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }

        private void setDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxP1.Text = "Justin";
            textBoxP2.Text = "Computer";
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            //setDefaultsToolStripMenuItem.PerformClick();
        }
    }
    // To remove the "Focus" on any buttons or text boxes..
    // Turn the parameter "tab stop" to false.
    // note: A focus label could be used to absorb focus
    // focusLabelName.Focus();
}
