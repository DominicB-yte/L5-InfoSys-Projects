using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP06Coursework
{
    public partial class ChangeText : Form
    {
        public ChangeText()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string replaced = input.Replace("e", "-");
            txtInput.Text = replaced;
        }
    }
}
