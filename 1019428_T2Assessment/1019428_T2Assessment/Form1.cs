using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1019428_T2Assessment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory InventoryPage;
            InventoryPage = new Inventory();
            InventoryPage.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales SalesPage;
            SalesPage = new Sales();
            SalesPage.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login LoginPage;
            LoginPage = new Login();
            LoginPage.ShowDialog();
        }
    }
}
