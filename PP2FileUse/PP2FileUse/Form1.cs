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

namespace PP2FileUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Starts at the Startup directory
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDirectory.Text = Application.StartupPath;
        }

        //Search for files matching the pattern and contain the target string 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the file pattern and target string.
            string pattern = cmbPattern.Text;
            string searched = txtSearchFor.Text.ToLower();
            // Clear the result list.
            lbDisplay.Items.Clear();
            // Search for files.
            DirectoryInfo dirinfo =
            new DirectoryInfo(txtDirectory.Text);
            foreach (FileInfo fileinfo in
            dirinfo.GetFiles(pattern, SearchOption.AllDirectories))
            {
                // See if we need to look for target text.
                if (searched.Length > 0)
                {
                    // If this file contains the target string,
                    // add it to the list.
                    string content =
                    File.ReadAllText(fileinfo.FullName).ToLower();
                    if (content.Contains(searched))
                        lbDisplay.Items.Add(fileinfo);
                }
                else
                {
                    // Just add this file to the list.
                    lbDisplay.Items.Add(fileinfo);
                }
            }

        }
    }
}
