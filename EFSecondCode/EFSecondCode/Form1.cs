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

namespace EFSecondCode
{
    public partial class Techtorium : Form
    {
        public Techtorium()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DOMINICBURNETT-;Initial Catalog=tested2;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO [tbl-Insertion] (ID, Name, FName, Age, Gender, Address)" + "values" + "('" +
                txtID.Text + "','" + txtName.Text + "','" + txtFName.Text + "','" + txtAge.Text + "','" + 
                cmbGender.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted data successfully.");
            txtID.Clear(); txtName.Clear();
            txtFName.Clear(); txtAge.Clear();
            cmbGender.SelectedIndex = (0);
            txtAddress.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE [tbl-Insertion]" + "set Name='" + txtName.Text + "',FName = '" + txtFName.Text
                + "',Age = '" + txtAge.Text + "',Gender = '" + cmbGender.Text + "',Address = '" + txtAddress.Text
                + "'" + "WHERE ID ='" + txtID.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated data successfully.");
            txtID.Clear(); txtName.Clear();
            txtFName.Clear(); txtAge.Clear();
            cmbGender.SelectedIndex = (0);
            txtAddress.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM [tbl-Insertion] WHERE ID ='" + txtID.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            con.Close();
            MessageBox.Show("Data deleted successfully.");
            txtID.Clear(); txtName.Clear();
            txtFName.Clear(); txtAge.Clear();
            cmbGender.SelectedIndex = (0);
            txtAddress.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM [tbl-Insertion]";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataView.DataSource = dt;
            con.Close();
        }
    }
}
