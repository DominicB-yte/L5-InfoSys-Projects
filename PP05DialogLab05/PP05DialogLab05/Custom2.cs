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
    public partial class Custom2 : Form
    {
        public bool IsLocked = true;
        public Custom2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string yes;
            yes = txtInput.Text;

            if (yes == "Given")
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
