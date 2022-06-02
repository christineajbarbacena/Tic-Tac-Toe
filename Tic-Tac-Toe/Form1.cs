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

            WinnerCheck();
        }

        private void WinnerCheck()
        {
            bool someone_wins = false;
            
            //Horizontal Check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled) )
                someone_wins = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                someone_wins = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                someone_wins = true;

            if (someone_wins)
            {
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show("Winner: " + winner, "Nice Game!");
            }//end of someone_wins


        }//end of winnerCheck

    }
}
