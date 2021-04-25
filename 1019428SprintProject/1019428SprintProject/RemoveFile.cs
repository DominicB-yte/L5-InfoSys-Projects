using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace _1019428SprintProject
{
    public partial class RemoveFile : Form
    {
        public RemoveFile()
        {
            InitializeComponent();
        }

        public static bool deleted;

        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;
        string ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=DAMdatabase;Integrated Security=True";

        private void RemoveFile_Load(object sender, EventArgs e)
        {
            lblFilename.Text = MainForm.nameRemove;

            connection = new SqlConnection(ConnectionString);
            connection.Open();
            string emptyQuery = "SELECT Filename, Filetype, Description, Dateuploaded FROM DAMtable WHERE Filename = '" + MainForm.nameRemove + "'";
            command = new SqlCommand(emptyQuery);
            command.Connection = connection;

            command.Parameters.Add(
            new SqlParameter(
            "@Fname", System.Data.SqlDbType.VarChar, 4000, "Filename"));

            command.Parameters["@Fname"].Value = MainForm.nameRemove;

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                lblFiletype.Text = (reader["Filetype"].ToString());
                txtDescription.Text = (reader["Description"].ToString());
                lblDate.Text = (reader["Dateuploaded"].ToString());
            }
            connection.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "Delete From dbo.DAMtable WHERE Filename ='" + MainForm.nameRemove + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Deleted");

            deleted = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
