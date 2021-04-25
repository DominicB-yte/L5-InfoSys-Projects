using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesCoursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BankAccount MyAccount;
        //Initialize the account
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the account
            MyAccount = new BankAccount();
            MyAccount.Balance = 100M;

            //Register to recieve the Overdrawn event
            MyAccount.overdrawn += MyAccount_Overdrawn;

            //Display the current balance
            txtBalance.Text = MyAccount.Balance.ToString("C");
        }

        //We're overdrawn
        private void MyAccount_Overdrawn(object sender, BankAccount.OverdrawnEventsArg arg)
        {
            MessageBox.Show("Insufficient Funds");
        }

        //Add money to the account
        private void btnCredit_Click(object sender, EventArgs e)
        {
            //Adds the money
            decimal amount = decimal.Parse(txtAmount.Text);
            MyAccount.Credit(amount);

            //Displays the current balance
            txtBalance.Text = MyAccount.Balance.ToString("C");
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            //Removes the money
            decimal amount = decimal.Parse(txtAmount.Text);
            MyAccount.Debit(amount);

            //Displays the current balance
            txtBalance.Text = MyAccount.Balance.ToString("C");
        }
    }
}
