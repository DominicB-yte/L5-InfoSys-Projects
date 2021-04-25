using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonMoveEvent(object sender, EventArgs e)
        {
            button1.Top += 10;
            button2.Top -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Top -= 10;
            button2.Top += 10;
        }

        private void EnablerClick(object sender, EventArgs e)
        {
            button4.Click += ButtonMoveEvent;
        }

        private void DisableClick(object sender, EventArgs e)
        {
            button4.Click -= ButtonMoveEvent;
        }
    }
}
