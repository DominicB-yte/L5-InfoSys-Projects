using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(0, 0);
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(200, 0);
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            label1.Location = new Point (0, 200);
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(200, 200);
        }
    }
}
