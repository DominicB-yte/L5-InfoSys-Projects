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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        SqlDataReader reader = null;
        SqlConnection connection = null;
        SqlCommand command = null;
        string ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=1019428_T2Assessment;Integrated Security=True";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();

            if (txtItemSearch.Text == "")
            {
                string emptyQuery = "SELECT ProdName, ProdQuantity FROM TechProducts";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                command.Parameters.Add(
                new SqlParameter(
                "@Search", System.Data.SqlDbType.VarChar, 50, "ProdName"));

                command.Parameters["@Search"].Value = txtItemSearch.Text;

                reader = command.ExecuteReader();

                lbDisplay.Items.Clear();
                while (reader.Read())
                {
                    lbDisplay.Items.Add(reader["ProdName"].ToString() + ":" +
                    " " + reader["ProdQuantity"].ToString());
                }
            }
            else
            {
                string queryText = "SELECT ProdName, ProdQuantity FROM TechProducts WHERE (ProdName LIKE @Search)";
                command = new SqlCommand(queryText);
                command.Connection = connection;

                command.Parameters.Add(
                    new SqlParameter(
                    "@Search", System.Data.SqlDbType.VarChar, 50, "ProdName"));

                command.Parameters["@Search"].Value = txtItemSearch.Text;

                reader = command.ExecuteReader();

                lbDisplay.Items.Clear();
                while (reader.Read())
                {
                    lbDisplay.Items.Add(reader["ProdName"].ToString() + ":" +
                    " " + reader["ProdQuantity"].ToString());
                }
            }

            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem UpdateItemPage;
            UpdateItemPage = new UpdateItem();
            UpdateItemPage.ShowDialog();

            var NewProdName = lbDisplay.SelectedIndex.ToString();
            String updatedProduct = NewProdName.Split(' ')[0];

            if (UpdateItemPage.setValues == true)
            {
                connection.Open();
                String query = "UPDATE [TechProducts] set ProdName= '" + UpdateItemPage.setProdName +
                "', ProdQuantity = " + UpdateItemPage.setQuantity + " WHERE ProdName = '" + UpdateItemPage.setProdName + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();

                connection.Close();
                txtItemSearch.Clear();
                lbDisplay.Items.Clear();
                MessageBox.Show("Updated data successfully.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var DelProduct = lbDisplay.SelectedIndex.ToString();
            string deletedProduct = DelProduct.Split(' ')[0];

            connection.Open();
            string query = "DELETE FROM [TechProducts] WHERE ProdName = '" + deletedProduct + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            connection.Close();

            if (lbDisplay.SelectedIndex >= 0)
            {
                lbDisplay.Items.RemoveAt(lbDisplay.SelectedIndex);
                txtItemSearch.Clear();
                MessageBox.Show("Data deleted successfully.");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem AddItemPage;
            AddItemPage = new AddItem();
            AddItemPage.ShowDialog();

            if (AddItemPage.addValues == true)
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = "INSERT INTO [TechProducts] (ProdName, ProdQuantity) values ('" +
                    AddItemPage.addProdName + "', '" + AddItemPage.addQuantity + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();

                connection.Close();
                txtItemSearch.Clear();
                lbDisplay.Items.Clear();
                MessageBox.Show("Inserted data successfully.");
            }
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            Login LoginPage;
            LoginPage = new Login();
            LoginPage.ShowDialog();
        }
    }
}
