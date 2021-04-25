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
    public partial class AmountSold : Form
    {
        public AmountSold()
        {
            InitializeComponent();
        }

        SqlConnection connection = null;
        SqlCommand command = null;
        String ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=1019428_T2Assessment;Integrated Security=True";

        private void btnUpdateRecords_Click(object sender, EventArgs e)
        {
            String productName = txtProductName.Text;
            int amountSold = Int32.Parse(txtAmountSold.Text);
            int overallQuantity = Int32.Parse(txtQuantityAvailable.Text);
            int newQuantity = overallQuantity - amountSold;

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            String query = "UPDATE [TechProducts] set ProdQuantity = " + newQuantity + " WHERE ProdName = '" + productName + "'";
            command = new SqlCommand(query);
            command.Connection = connection;
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();

            connection.Close();
            txtProductName.Clear();
            txtQuantityAvailable.Clear();
            txtAmountSold.Clear();
            MessageBox.Show("Updated records successfully.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
