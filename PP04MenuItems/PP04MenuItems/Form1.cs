using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP04MenuItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lorem Ipsum Dolor";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text = richTextBox1.SelectedText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\L5 InfoSys\richTextbox.rtf");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\L5 InfoSys\richTextbox.rtf");
        }
    }
}
