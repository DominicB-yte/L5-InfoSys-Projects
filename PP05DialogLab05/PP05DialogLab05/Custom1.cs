using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05DialogLab05
{
    public partial class Custom1 : Form
    {
        public bool IsLocked = true;
        public Custom1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string confirm;
            confirm = txtInput.Text;

            if (confirm == "Input")
            {
                IsLocked = false;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect input given");
            }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
