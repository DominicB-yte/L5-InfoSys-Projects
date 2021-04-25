using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP09ArraysClasswork
{
    public partial class Order : Form
    {
        private Dictionary<int, string> orders = new Dictionary<int, string>();
        public Order()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orders.Add(int.Parse(txtID.Text), txtItems.Text);
            txtID.Clear();
            txtItems.Clear();
            txtID.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtItems.Text = orders[int.Parse(txtID.Text)];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            orders[int.Parse(txtID.Text)] = txtItems.Text;
        }
    }
}
