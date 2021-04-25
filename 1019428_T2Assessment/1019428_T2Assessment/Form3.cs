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

namespace _1019428_T2Assessment
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DOMINICBURNETT-;Initial Catalog=1019428_T2Assessment;Integrated Security=True");

        public string addProdName;
        public string addQuantity;
        public bool addValues = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addProdName = txtProduct.Text;
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
