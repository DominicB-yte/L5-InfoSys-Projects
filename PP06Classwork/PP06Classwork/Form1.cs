using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP06Classwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Equation for the 1st item
            string item1 = txtItem1.Text;
            decimal qty1 = numUpDownQuantity1.Value;
            decimal price1 = Convert.ToDecimal(txtPriceEach1.Text);
            txtItemTotal1.Text = (price1 * qty1).ToString();
            decimal total1 = Convert.ToDecimal(txtItemTotal1.Text);

            //Equation for the 2nd item
            string item2 = txtItem2.Text;
            decimal qty2 = numUpDownQuantity2.Value;
            decimal price2 = Convert.ToDecimal(txtPriceEach2.Text);
            txtItemTotal2.Text = (price2 * qty2).ToString();
            decimal total2 = Convert.ToDecimal(txtItemTotal2.Text);

            //Equation for the 3rd item
            string item3 = txtItem3.Text;
            decimal qty3 = numUpDownQuantity3.Value;
            decimal price3 = Convert.ToDecimal(txtPriceEach3.Text);
            txtItemTotal3.Text = (price3 * qty3).ToString();
            decimal total3 = Convert.ToDecimal(txtItemTotal3.Text);

            //Equation for the 4th item
            string item4 = txtItem4.Text;
            decimal qty4 = numUpDownQuantity4.Value;
            decimal price4 = Convert.ToDecimal(txtPriceEach4.Text);
            txtItemTotal4.Text = (price4 * qty4).ToString();
            decimal total4 = Convert.ToDecimal(txtItemTotal4.Text);

            //Equation for the Subtotal
            txtSubtotal.Text = (total1 + total2 + total3 + total4).ToString();
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);


            //Equation for the Sales Tax
            decimal tax = Convert.ToDecimal(txtTaxRate.Text);
            txtSalesTax.Text = (subtotal * tax).ToString();
            decimal saletax = Convert.ToDecimal(txtSalesTax.Text);

            //Equation for the Total
            decimal shipping = Convert.ToDecimal(txtShipping.Text);
            txtGrossTotal.Text = (subtotal + saletax + shipping).ToString();
            decimal grosstotal = Convert.ToDecimal(txtGrossTotal.Text);

            //Rounding the Sales Tax and Gross Total
            txtSalesTax.Text = Math.Round(saletax , 2, MidpointRounding.AwayFromZero).ToString("C2");
            txtGrossTotal.Text = Math.Round(grosstotal, 2, MidpointRounding.AwayFromZero).ToString("C2");
        }
    }
}
