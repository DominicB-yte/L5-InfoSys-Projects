using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP05Dialogs
{
    public partial class DiaLockd : Form
    {
        public bool IsLocked = true;

        public DiaLockd()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string uName;
            uName = txtUsername.Text;

            string pWord;
            pWord = txtPassword.Text;

            

            
            if (uName == "admin")
            {
                if (pWord == "admin")
                {
                    IsLocked = false;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
            }
            else
            {
                MessageBox.Show("Username or Password incorrect");

            }
        }
    }
}
