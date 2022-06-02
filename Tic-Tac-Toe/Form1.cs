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


        }
    }
}
