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
        //static String player1, player2;

        public TicTacToe()
        {
            InitializeComponent();
        }

        /*public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }*/

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
            // Will store the sender object in variable b
            Button b = (Button)sender;
            // Determines whos turn it is by "turn" true/false value.
            // This is statement will toggle "turn" true/false creating alternate turns
            if(turn)
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
        }// End buttonClick

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
            }// End if(thereIsAWinner)
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw!", "Bummer...");
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
                    catch {}
                }// End foreach
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
        }

        /*private void TicTacToe_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            xWins.Text = player1;
            oWins.Text = player2;
        }*/
    }
}
