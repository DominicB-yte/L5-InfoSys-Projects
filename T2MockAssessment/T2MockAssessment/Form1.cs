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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }
        SqlDataReader reader = null;
        SqlConnection connection = null;
        SqlCommand command = null;

        //SqlConnection connection = new SqlConnection(@"Data Source=DOMINICBURNETT-;Initial Catalog=T2MockAssessment;Integrated Security=True;
            //Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //string query = "SELECT ProductName FROM inventory" + " " + "WHERE (ProductName = @name)";
            //string Item = Convert.ToString("ProductName" + " " + "Quantity");
            //SqlCommand command = new SqlCommand(query, connection);

            //command.Parameters.Add(
                //new SqlParameter("@name", System.Data.SqlDbType.VarChar, 50, "ProductName"));
            //command.Parameters["@name"].Value = txtItemSearch.Text;

            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
                //lbDisplay.Items.Add(reader["ProductName"].ToString() +
                    //" " + reader["Quantity"].ToString());
            //}
            //connection.Close();

            // Open connection to the database
            string ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=T2MockAssessment;Integrated Security=True";
            connection = new SqlConnection(ConnectionString);
            connection.Open();

            // Set up a command with the given query and associate
            // this with the current connection.
            string CommandText = "SELECT ProductName, Quantity" +
                                 "  FROM inventory" +
                                 " WHERE (ProductName LIKE @Find)";
            command = new SqlCommand(CommandText);
            command.Connection = connection;

            // Add LastName to the above defined paramter @Find
            command.Parameters.Add(
                new SqlParameter(
                "@Find", // The name of the parameter to map
                System.Data.SqlDbType.VarChar, // SqlDbType values
                50, // The width of the parameter
                "ProductName"));  // The name of the source column

            // Fill the parameter with the value retrieved
            // from the text field
            command.Parameters["@Find"].Value = txtItemSearch.Text;

            // Execute the query
            reader = command.ExecuteReader();

            // Fill the list box with the values retrieved
            lbDisplay.Items.Clear();
            while (reader.Read())
            {
                lbDisplay.Items.Add(reader["ProductName"].ToString() + ":" +
                " " + reader["Quantity"].ToString() + '.');
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update UpdatePage;
            UpdatePage = new update();
            UpdatePage.ShowDialog();


            //string firsWord = lbDisplay.SubString(0, lbDisplay.IndexOf(' '));
            //string remainingSentence = sentence.SubString(sentence.IndexOf(' '), sentence.Length);

            if (UpdatePage.setValues == true)
            {
                connection.Open();
                string query = "UPDATE inventory set ProductName= '" + UpdatePage.setProductName + "', Quantity = '" + UpdatePage.setQuantity
                + "' WHERE ProductName = '" + txtItemSearch.Text + "'";
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
            connection.Open();
            string query = "DELETE FROM inventory WHERE ProductName LIKE '" + lbDisplay.SelectedIndex + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            connection.Close();
            Console.WriteLine("Delete key pressed");
            if (lbDisplay.SelectedIndex >= 0)
            {
                lbDisplay.Items.RemoveAt(lbDisplay.SelectedIndex);
                MessageBox.Show("Data deleted successfully.");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            add AddPage;
            AddPage = new add();
            AddPage.ShowDialog();
            if (AddPage.addValues == true)
            {
                connection.Open();
                string query = "INSERT INTO [inventory] (ProductName, Quantity)" + "values" + "('" +
                    AddPage.addProductName + "','" + AddPage.addQuantity + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                txtItemSearch.Clear();
                lbDisplay.Items.Clear();
                MessageBox.Show("Inserted data successfully.");
            }
        }
    }
}
