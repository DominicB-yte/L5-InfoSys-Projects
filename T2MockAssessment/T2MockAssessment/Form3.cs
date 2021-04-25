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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DOMINICBURNETT-;Initial Catalog=inventory;Integrated Security=True");

        public string setProductName;
        public string setQuantity;
        public bool setValues = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            setProductName = txtProduct.Text;
            setQuantity = txtQuantity.Text;
            setValues = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
