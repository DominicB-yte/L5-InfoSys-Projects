using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP06Debugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Reads the Age
            int age;
            age = Convert.ToInt32(txtAge.Text);

            if (age < 18)
            {
                pnlNo.Visible = true;
                pnlYes.Visible = false;
            }
            else
            {
                pnlYes.Visible = true;
                pnlNo.Visible = false;
            }
        }
    }
}
