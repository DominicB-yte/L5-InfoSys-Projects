using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace T2MockAssessment
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DOMINICBURNETT-;Initial Catalog=inventory;Integrated Security=True");

        public string addProductName;
        public string addQuantity;
        public bool addValues = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProductName = txtProduct.Text;
            addQuantity = txtQuantity.Text;
            addValues = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
