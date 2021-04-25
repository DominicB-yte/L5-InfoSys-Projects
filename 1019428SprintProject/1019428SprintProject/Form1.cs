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
using System.Web;

namespace _1019428SprintProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string nameRemove;

        OpenFileDialog ofd = new OpenFileDialog();

        SqlConnection connection = null;
        SqlCommand command = null;
        String ConnectionString = @"Data Source=DOMINICBURNETT-;Initial Catalog=DAMdatabase;Integrated Security=True; MultipleActiveResultSets=true";

        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            ofd.Filter = "PDF Files (*.pdf)|*.pdf| Image Files (*.jpg, *.jpeg)|*.jpg; *.jpeg| GIF Files (*.gif)|*.gif| MP4 Files (*.mp4)|*.mp4";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.FileName.Length > 0)
                {
                    string filePath = ofd.FileName;
                    txtFilepath.Text = filePath;

                    if (filePath.Contains(".jpg") || filePath.Contains(".jpeg"))
                    {
                        picPreview.ImageLocation = filePath;

                    }

                }
            }
        }



        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Substring for the File Name
            String flPath = txtFilepath.Text;
            int toPathIndex = flPath.LastIndexOf("\\") + 1;
            int fromPathIndex = flPath.LastIndexOf(".");
            String fileName = flPath.Substring(toPathIndex, fromPathIndex - toPathIndex).Trim();

            //Substring for the File Type
            int toTypeIndex = flPath.LastIndexOf(".") + 1;
            String fileType = flPath.Substring(toTypeIndex, flPath.Length - toTypeIndex).Trim();

            DateTime date = DateTime.Now;
            String sqlDate = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

            String Description = txtDescription.Text;
            String Colour = txtColour.Text;
            String Department = null;

            if (cmbDepartment.SelectedIndex > -1)
            {
                Department = cmbDepartment.SelectedItem.ToString();
            }
            else if (cmbDepartment.SelectedIndex == -1)
            {
                Department = "n/a";
            }

            byte[] FileBytes = null;
            var contents = "pdf/jpg/gif/mp4";

            if (contents != String.Empty)
            {

                // Open file to read using file path
                FileStream FS = new FileStream(txtFilepath.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // Add filestream to binary reader
                BinaryReader BR = new BinaryReader(FS);

                // get total byte length of the file
                long allbytes = new FileInfo(txtFilepath.Text).Length;

                // read entire file into buffer
                FileBytes = BR.ReadBytes((Int32)allbytes);

                //Insert all the values into the databse
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand("insert into DAMtable(Filepath, Filename, Filetype, Description, Colour, Department, Dateuploaded) " +
                    "values (@FB, @FN, @FT, @DC, @CL, @DP, @DT)", connection);
                sqlcmd.Parameters.AddWithValue("@FB", FileBytes);
                sqlcmd.Parameters.AddWithValue("@FN", fileName);
                sqlcmd.Parameters.AddWithValue("@FT", fileType);
                sqlcmd.Parameters.AddWithValue("@DC", Description);
                sqlcmd.Parameters.AddWithValue("@CL", Colour);
                sqlcmd.Parameters.AddWithValue("@DP", Department);
                sqlcmd.Parameters.AddWithValue("@DT", sqlDate);
                sqlcmd.ExecuteNonQuery();
                connection.Close();

                // close all instances
                FS.Close();
                FS.Dispose();
                BR.Close();

                txtFilepath.Clear(); txtDescription.Clear(); txtColour.Clear();
                lblDesc.Hide(); lblColour.Hide(); lblDept.Hide();
                txtDescription.Hide(); txtColour.Hide(); cmbDepartment.Hide();
                cmbDepartment.SelectedIndex = -1;
                cmbTags.SelectedIndex = -1;
                picPreview.Image = null;

                MessageBox.Show("Uploaded file Successfully");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtFile.Text != "")
            {
                nameRemove = txtFile.Text;

                RemoveFile RemoveFilePage;
                RemoveFilePage = new RemoveFile();
                RemoveFilePage.ShowDialog();
            }

            if (RemoveFile.deleted == true)
            {
                txtFile.Clear();
            }
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            SearchFor SearchForPage;
            SearchForPage = new SearchFor();
            SearchForPage.ShowDialog();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConnectionString);
            String selectQuery = "SELECT Filepath, Filename, Filetype from DAMtable where Filename =" + "'" + txtFile.Text + "'";
            command = new SqlCommand(selectQuery);
            connection.Open();
            SqlCommand dwnldCmd = new SqlCommand(selectQuery, connection);
            command.Connection = connection;
            dwnldCmd.CommandType = CommandType.Text;

            String fileName = null;
            String fileType = null;

            SqlDataReader dwnldReader = dwnldCmd.ExecuteReader();
            dwnldReader.Read();

            fileName = (dwnldReader["Filename"].ToString());
            fileType = (dwnldReader["Filetype"].ToString());


            byte[] bits1;
            bits1 = (byte[])dwnldReader[0];

            String path = "C:\\L5 InfoSys\\1019428SprintProject\\DAM-download\\" + fileName + "." + fileType;

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                fs.Write(bits1, 0, bits1.Length);
                fs.Flush();
            }
            dwnldReader.Close();
            MessageBox.Show("File Downloaded");
            if (txtFile.Text != "")
            {
                txtFile.Clear();
            }
        }

        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTags.SelectedIndex == 0)
            {
                lblDesc.Visible = true;
                txtDescription.Visible = true;
                lblColour.Visible = false;
                txtColour.Visible = false;
                lblDept.Visible = false;
                cmbDepartment.Visible = false;
            }
            if (cmbTags.SelectedIndex == 1)
            {
                lblDesc.Visible = true;
                txtDescription.Visible = true;
                lblColour.Visible = true;
                txtColour.Visible = true;
                lblDept.Visible = false;
                cmbDepartment.Visible = false;
            }
            if (cmbTags.SelectedIndex == 2)
            {
                lblDesc.Visible = true;
                txtDescription.Visible = true;
                lblColour.Visible = true;
                txtColour.Visible = true;
                lblDept.Visible = true;
                cmbDepartment.Visible = true;
            }
        }
    }
}
