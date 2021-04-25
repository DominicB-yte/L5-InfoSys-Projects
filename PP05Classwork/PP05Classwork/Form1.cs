using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05Classwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomDialog_Click(object sender, EventArgs e)
        {
            LockPage Enabler;
            Enabler = new LockPage();
            Enabler.ShowDialog();

            if (Enabler.IsChanged == false)
            {
                lblChanger.Text = "[CURRENTLY ENABLED]";
            }
        }
    }
}
