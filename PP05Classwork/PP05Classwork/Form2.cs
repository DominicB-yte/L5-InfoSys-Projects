using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05Classwork
{
    public partial class LockPage : Form
    {
        public bool IsChanged = true;
        public LockPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pWord;
            pWord = txtPassword.Text;


            if (pWord == "SecretEmperor")
                {
                    IsChanged = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Password is Incorrect");
                }
            }
        }
    }
