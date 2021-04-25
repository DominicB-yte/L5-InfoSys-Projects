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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string inputString;
            inputString = txtIn.Text;
            //finds the first space 
            int spaceIndex = inputString.IndexOf(' ');
            //gets the text from the start to 
            string qty = inputString.Substring(0, spaceIndex);
            txtAmount.Text = qty;
            //gets product
            int atIndex = inputString.LastIndexOf('@');
            Text = atIndex.ToString();
            txtProduct.Text = inputString.Substring(spaceIndex + 1, atIndex - spaceIndex);

            int copyProdLength = atIndex - spaceIndex - 1;
            txtProduct.Text = inputString.Substring(spaceIndex, copyProdLength).Trim();

            int eachIndex = inputString.LastIndexOf("each");

            txtUnitPrice.Text = inputString.Substring(atIndex + 1, eachIndex - atIndex - 1).Trim();

            int lastDollar = inputString.LastIndexOf("$");
            txtTotal.Text = inputString.Substring(lastDollar, inputString.Length - lastDollar).Trim();
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            Form2_Load(null, null);
        }
    }
}
