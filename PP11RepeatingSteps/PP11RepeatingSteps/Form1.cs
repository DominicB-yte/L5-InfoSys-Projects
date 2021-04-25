using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP11RepeatingSteps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //The equation for the 1st Price
            decimal eachPrice = Convert.ToDecimal(txtPricesEach1.Text);
            int qty = Convert.ToInt32(txtQuantity1.Text);
            txtPrices1.Text = (eachPrice * qty).ToString();

            //The equation for the 2nd Price
            decimal eachPrice2 = Convert.ToDecimal(txtPricesEach2.Text);
            int qty2 = Convert.ToInt32(txtQuantity2.Text);
            txtPrices2.Text = (eachPrice2 * qty2).ToString();

            //The equation for the 3rd Price
            decimal eachPrice3 = Convert.ToDecimal(txtPricesEach3.Text);
            int qty3 = Convert.ToInt32(txtQuantity3.Text);
            txtPrices3.Text = (eachPrice3 * qty3).ToString();

            //The equation for the 4th Price
            decimal eachPrice4 = Convert.ToDecimal(txtPricesEach4.Text);
            int qty4 = Convert.ToInt32(txtQuantity4.Text);
            txtPrices4.Text = (eachPrice4 * qty4).ToString();

            //The equation for the Subtotal
            decimal prices1 = Convert.ToDecimal(txtPrices1.Text);
            decimal prices2 = Convert.ToDecimal(txtPrices2.Text);
            decimal prices3 = Convert.ToDecimal(txtPrices3.Text);
            decimal prices4 = Convert.ToDecimal(txtPrices4.Text);
            decimal pricesAll = (prices1 + prices2 + prices3 + prices4);
            txtSubtotal.Text = pricesAll.ToString();

            //The equation for the Sales Tax
            decimal tax = Convert.ToDecimal(0.07);
            txtSalesTax.Text = (pricesAll * tax).ToString();
            decimal saletax = Convert.ToDecimal(txtSalesTax.Text);
            txtSalesTax.Text = Math.Round(saletax, 2, MidpointRounding.AwayFromZero).ToString();

            //The equation for calculating the shipping cost
            decimal shipping;
            if (pricesAll < 75)
            {
                shipping = (10);

                if (pricesAll < 50)
                {
                    shipping = 7.5m;

                    if (pricesAll < 25)
                    {
                        shipping = 5;
                    }
                }
            }
            else
            {
                shipping = 0;
            }
            txtShipping.Text = shipping.ToString();

            //Equation for calculating the grand total
            decimal grandtotal = pricesAll + saletax + shipping;
            txtGrandTotal.Text = grandtotal.ToString();
            txtGrandTotal.Text = Math.Round(grandtotal, 2, MidpointRounding.AwayFromZero).ToString();

        }
    }
}
