using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebuggingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtIn.Text;

            int qty;
            double costMoney;
            double totalCost;

            string quantity = input.Split('/')[0];
            string item = input.Split('/')[1];
            string cost = input.Split('/')[2];
            string total = input.Split('/')[3];

            qty = int.Parse(quantity);
            totalCost = double.Parse(total);
            costMoney = double.Parse(cost);

            txtOut.Text =
                qty.ToString("N0") + " " +
                item + " @ " +
                costMoney.ToString("C2") + " each = " +
                totalCost.ToString("C2");
        }
    }
}
