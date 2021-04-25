using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP02TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblx00_Click(object sender, EventArgs e)
        {
            lblTaken00.Text = "X";
        }

        private void lblo00_Click(object sender, EventArgs e)
        {
            lblTaken00.Text = "O";
        }

        private void lblx10_Click(object sender, EventArgs e)
        {
            lblTaken10.Text = "X";
        }

        private void lblo10_Click(object sender, EventArgs e)
        {
            lblTaken10.Text = "O";
        }

        private void lblx20_Click(object sender, EventArgs e)
        {
            lblTaken20.Text = "X";
        }

        private void lblo20_Click(object sender, EventArgs e)
        {
            lblTaken20.Text = "O";
        }

        private void lblx01_Click(object sender, EventArgs e)
        {
            lblTaken01.Text = "X";
        }

        private void lblo01_Click(object sender, EventArgs e)
        {
            lblTaken01.Text = "O";
        }

        private void lblx11_Click(object sender, EventArgs e)
        {
            lblTaken11.Text = "X";
        }

        private void lblo11_Click(object sender, EventArgs e)
        {
            lblTaken11.Text = "O";
        }

        private void lblx21_Click(object sender, EventArgs e)
        {
            lblTaken21.Text = "X";
        }

        private void lblo21_Click(object sender, EventArgs e)
        {
            lblTaken21.Text = "O";
        }

        private void lblx02_Click(object sender, EventArgs e)
        {
            lblTaken02.Text = "X";
        }

        private void lblo02_Click(object sender, EventArgs e)
        {
            lblTaken02.Text = "O";
        }

        private void lblx12_Click(object sender, EventArgs e)
        {
            lblTaken12.Text = "X";
        }

        private void lblo12_Click(object sender, EventArgs e)
        {
            lblTaken12.Text = "O";
        }

        private void lblx22_Click(object sender, EventArgs e)
        {
            lblTaken22.Text = "X";
        }

        private void lblo22_Click(object sender, EventArgs e)
        {
            lblTaken22.Text = "O";
        }

        private void lblPico_Click(object sender, EventArgs e)
        {
            pbxTaken.Visible = true;
            pbxTaken2.Visible = false;
        }

        private void lblPicx_Click(object sender, EventArgs e)
        {
            pbxTaken2.Visible = true;
            pbxTaken.Visible = false;
        }
    }
}
