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

namespace _1019428SprintProject
{
    public partial class SearchFor : Form
    {
        public SearchFor()
        {
            InitializeComponent();
        }

        SqlConnection connection = null;
        SqlCommand command = null;
        DataTable data = new DataTable();
        string ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=DAMdatabase;Integrated Security=True";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbDropDown.SelectedIndex == 0)
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string emptyQuery = "SELECT Filename, Filetype, Description, Colour, Department, Dateuploaded FROM DAMtable";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sqlDataAdap.Fill(dt);
                dataGrid.DataSource = dt;
            }

            if (cmbDropDown.SelectedIndex == 1)
            {
                string nameSearch = txtSearch.Text;

                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string emptyQuery = "SELECT Filename, Filetype, Description, Colour, Department, Dateuploaded FROM DAMtable  WHERE (Filename LIKE '%' + @Search + '%')";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                command.Parameters.Add(
                new SqlParameter("@Search", System.Data.SqlDbType.VarChar, 4000, "Filename"));

                command.Parameters["@Search"].Value = nameSearch;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sqlDataAdap.Fill(dt);
                dataGrid.DataSource = dt;
            }

            if (cmbDropDown.SelectedIndex == 2)
            {
                string typeSearch = txtSearch.Text;

                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string emptyQuery = "SELECT Filename, Filetype, Description, Colour, Department, Dateuploaded FROM DAMtable  WHERE (Filetype LIKE '%' + @Search + '%')";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                command.Parameters.Add(
                new SqlParameter("@Search", System.Data.SqlDbType.VarChar, 4000, "Filetype"));

                command.Parameters["@Search"].Value = typeSearch;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sqlDataAdap.Fill(dt);
                dataGrid.DataSource = dt;
            }

            if (cmbDropDown.SelectedIndex == 3)
            {
                string descSearch = txtSearch.Text;

                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string emptyQuery = "SELECT Filename, Filetype, Description, Colour, Department, Dateuploaded FROM DAMtable  WHERE (Description LIKE '%' + @Search + '%')";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                command.Parameters.Add(
                new SqlParameter("@Search", System.Data.SqlDbType.VarChar, 4000, "Description"));

                command.Parameters["@Search"].Value = descSearch;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sqlDataAdap.Fill(dt);
                dataGrid.DataSource = dt;
            }

            if (cmbDropDown.SelectedIndex == 4)
            {
                string deptSearch = txtSearch.Text;

                connection = new SqlConnection(ConnectionString);
                connection.Open();
                string emptyQuery = "SELECT Filename, Filetype, Description, Colour, Department, Dateuploaded FROM DAMtable  WHERE (Description LIKE '%' + @Search + '%')";
                command = new SqlCommand(emptyQuery);
                command.Connection = connection;

                command.Parameters.Add(
                new SqlParameter("@Search", System.Data.SqlDbType.VarChar, 4000, "Description"));

                command.Parameters["@Search"].Value = deptSearch;

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sqlDataAdap.Fill(dt);
                dataGrid.DataSource = dt;
            }
        }


        private void cmbDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDropDown.SelectedIndex == 0)
            {
                txtSearch.Clear();
                txtSearch.ReadOnly = true;
            }
            else
            {
                txtSearch.Clear();
                txtSearch.ReadOnly = false;
            }
        }
    }
}
