using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true means X turn; false means O turn
        int turn_count = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            if (turn)
                a.Text = "X";
            else
                a.Text = "O";
            turn = !turn;
            a.Enabled = false;
            turn_count++;

            WinnerCheck();
        }

        private void WinnerCheck()
        {
            bool someone_wins = false;
            
            //Horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled) )
                someone_wins = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                someone_wins = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                someone_wins = true;

            //Vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                someone_wins = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                someone_wins = true;
            else if ((A1.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                someone_wins = true;

            //Diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                someone_wins = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                someone_wins = true;

            if (someone_wins)
            {
                DisablingButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("Winner: " + winner, "Nice Game <3!");
            }//end of someone_wins

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!", "Play Again :>");

            }//end of else

        }//end of winnerCheck

        private void DisablingButtons()
        {
            try
            {
                foreach (Control disable in Controls)
                {
                    Button a = (Button)disable;
                    a.Enabled = false;
                }//foreach
            }//end of try
            catch { }
        }//end for DisablingButtons

        private void aboutTicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also called noughts and crosses, or Xs and Os is a game for two players who take turns marking the spaces in a three-by-three grid with X or O. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row is the winner. -Wikipedia", "Tic Tac Toe");
        }

        private void designerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("By: Christine April Joy Barbacena");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control disable in Controls)
                {
                    Button a = (Button)disable;
                    a.Enabled = true;
                    a.Text = "";
                }
            }//end of try
            catch { }


        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
