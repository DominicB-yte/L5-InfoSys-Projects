using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormativeAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double P = Convert.ToDouble(txtPrice.Text);
            int Q = Convert.ToInt32(txtQuantity.Text);
            double PQ = (P * Q);
            chkCart.Items.Add(cmbProduct.Text + "\t" + txtPrice.Text + "\t" + txtQuantity.Text + "\t" + PQ);
            txtSubtotal.Text = PQ.ToString();
            //txtGST.Text = ;
            //txtTotal.Text = ;
        }
    }
}
